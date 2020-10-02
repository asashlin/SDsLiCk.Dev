using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using IBA.SDsLiCk.CodeGen;
using IBA.SDsLiCk.GUIBuilder.Properties;

namespace IBA.SDsLiCk.GUIBuilder
{
    partial class CtrlParser
    {
        private static NextStateBuilder s_nxtStateFuncBldr = new NextStateBuilder();
        private static Dictionary<NSRecRef, NextStateRec> s_seqRefBldr = new Dictionary<NSRecRef, NextStateRec>();
        private static Regex s_langDefRE = new Regex(@"(?<name>^[a-zA-Z_]+(?:\{[a-zA-Z_]+\}|\([a-zA-Z_]+\)|\[[a-zA-Z_]+\])?):");

        public static NextStateFunc NextStateFunc { get; }

        static CtrlParser()
        {
            NextStateRec next, back;     // used to create a sequence of token states
            NextStateRec record;         // used to create a sequence of token states
            NextStateRec @base = null;   // holds the current record used as the base for a sequence of tokens


            FileRef ctrlParserDef = Settings.Default.CSLangDefFilePath;
            Initialise(ctrlParserDef);
            //string[] lines = File.ReadAllLines(filepath);
            //foreach (string line in lines)
            //{
            //    Match match = s_langDefRE.Match(line);
            //    // HACK: building the definition by hand for now -just reading file to confirm completeness

            //    if (!match.Success)
            //        continue;

            //    string name = match.Groups["name"].Value;

            //}

            NextStateFunc = s_nxtStateFuncBldr.NextStateFunc;
        }

        private static void Initialise(FileRef ctrlParserDef)
        {
            // HACK: this code assumes a gramma definition exist on the 1st line after header line (line/row 2)
            NextStateRec nsRec;
            string[] lines = File.ReadAllLines(ctrlParserDef);
            int len = lines.Length;

            if (len < 2)
                throw new FormatException("The CtrlParserDef.csv file has less than 2 lines and more lines are expected!");

            if (!lines[0].StartsWith("Gramma,Gramma Definition,Object,Sequence,Alternate,Response,Action,"))
                throw new FormatException("The CtrlParserDef.csv file does not have a header column in the correct format!");

            nsRec = ProcessDefLine(lines[1], out int seqNo, out string seq2Obj, out string alt2Obj);
            s_nxtStateFuncBldr.SetNextStateStartRecord(nsRec);                                       // HACK: it is assumed that the Start Record will be a GrammaDef object
            nsRec = nsRec.Sequence;
            s_seqRefBldr.Add(new NSRecRef(seqNo, nsRec.Identifier, seq2Obj, alt2Obj), nsRec);
            for (int i = 2; i < len; i++)
            {
                nsRec = ProcessDefLine(lines[i], out seqNo, out seq2Obj, out alt2Obj);
                if (nsRec != null)    // not a blank line
                {
                    if (nsRec.OfType == NextStateRec.Type.GrammaDef)
                    {
                        ProcessNSRecReferencesAndReset();      //  Adds links to NextStateRecs using the 's_seqRefBldr' and clears it for the next gramma definition 
                        s_nxtStateFuncBldr.AddNSRecordRef(nsRec.Name, nsRec);
                        nsRec = nsRec.Sequence;
                    }
                    s_seqRefBldr.Add(new NSRecRef(seqNo, nsRec.Identifier, seq2Obj, alt2Obj), nsRec);
                }
            }

        }

        private static void ProcessNSRecReferencesAndReset()
        {
            // Get the Sequence and Alternate references, find their references in the 
            foreach (KeyValuePair<NSRecRef, NextStateRec> item in s_seqRefBldr)
            {
                int seqNo;
                // HACK: no error checking 
                NSRecRef nsRecRef = item.Key;
                NextStateRec nsRec = item.Value;
                Debug.WriteLine($"SeqNo={nsRecRef.SeqNo}, ID={nsRecRef.Identifier}, Hash={nsRecRef.GetHashCode()} ", "NSRecRef");
                string objRef = nsRecRef.Sequence;
                if (!string.IsNullOrEmpty(objRef))
                {
                    seqNo = NSRecRef.ExtractReference(ref objRef);
                    NSRecRef nsSeqRef = new NSRecRef(seqNo, objRef);
                    Debug.WriteLine(objRef, "nsSeqRef");
                    NextStateRec nsSeqRec = s_seqRefBldr[nsSeqRef];
                    s_nxtStateFuncBldr.AddSequenceNSRecord(nsRec, nsSeqRec);
                }
                objRef = nsRecRef.Alternate;
                if (!string.IsNullOrEmpty(objRef))
                {
                    seqNo = NSRecRef.ExtractReference(ref objRef);
                    NSRecRef nsAltRef = new NSRecRef(seqNo, objRef);
                    NextStateRec nsAltRec = s_seqRefBldr[nsAltRef];
                    s_nxtStateFuncBldr.AddAlternativeNSRecord(nsRec, nsAltRec);
                }
            }

            s_seqRefBldr.Clear();    // clears the list for the next Gramma definition
                                     //throw new NotImplementedException();
        }

        private static NextStateRec ProcessDefLine(string line, out int seqNo, out string seq2Obj, out string alt2Obj)
        {
            NextStateRec nsRec, nsDef = null;

            UnEscapeQuotes(ref line);

            // extract the lines values as required
            string[] cols = line.Split(10, ',');
            string objRef = cols[2];
            if (!string.IsNullOrWhiteSpace(objRef))
            {
                if (!Enum.TryParse(cols[5].Trim(), out ParseResponse response))
                    throw new FormatException($"Response '{cols[5].Trim()}' not a valid ParseResponse value in: {line}");
                seqNo = NSRecRef.ExtractReference(ref objRef);
                nsRec = NextStateRec.CreateNSObject(objRef, response);
            }
            else  // must be a blank line so return nothing
            {
                seq2Obj = string.Empty;
                alt2Obj = string.Empty;
                seqNo = 0;
                return null;
            }
            string gramma = cols[0];       
            // column '1' ignored, is for user reference to the gramma being defined
            seq2Obj = cols[3].Trim();
            alt2Obj = cols[4].Trim();
            string action = cols[6].Trim();
            // columns 7 onwards ignored and can be used for comments as desired


            // process a Gramma definition line (1st line in sequence) if existant and return nsDEf/nsRec sequence pair
            if (!string.IsNullOrWhiteSpace(gramma))
            {
                nsDef = NextStateRec.CreateGrammaDef(gramma.TrimEnd(':'));    //NOTE: colon is optional
                s_nxtStateFuncBldr.AddSequenceNSRecord(nsDef, nsRec);
                return nsDef;
            }
             
            // OR: just return the Next State Record
            else
                return nsRec;
        }


        private static void UnEscapeQuotes(ref string line)
        {
            line = line.Replace(",\"",",").Replace("\",",",").Replace("\"\"","\"");
        }

        // resolve the not yet linked records
        //s_nxtStateFuncBldr.ResolveUnlinkedRecords();


    }
}