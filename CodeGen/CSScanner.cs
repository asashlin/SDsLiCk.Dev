using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBA.SDsLiCk.CodeGen.Properties;

namespace IBA.SDsLiCk.CodeGen.CS
{
    public class CSScanner<TRecord, TType>
    {
        public delegate SourceObject CreateSrcObjDelegate(TRecord record);
        public CreateSrcObjDelegate CreateSourceObject;

        private readonly Regex m_defRE = new Regex(@"(?<preprocessor>^\s*#\s*)(?<identifier>[_A-Za-z@][_A-Za-z0-9]*)|(?<blank>^\s*$)|(?<comment>(?://.*$)|/\*.*?(?:\*/|$))|(?<ws>\s+)|(?<string>""[^""\\\r\n]*(?:\\.[^""\\\r\n]*)*"")|(?<identifier>[_A-Za-z@][_A-Za-z0-9]*)|(?<symbol>[^ \w]+)");
        private readonly SymbolTable<TRecord, TType> m_symbolTable;
        private readonly TType[] m_typeList;

        public CSScanner(SymbolTable<TRecord, TType>.CreateRecordDelegate createSymbolRecord, CreateSrcObjDelegate createSourceObject, TType[] types)
        {
            m_symbolTable = new SymbolTable<TRecord, TType>(createSymbolRecord);
            CreateSourceObject += createSourceObject;
            m_typeList = types;

            foreach (string symbol in Settings.Default.Keywords.Split(' '))
                m_symbolTable.Add(symbol, types[0]);

            foreach (string symbol in Settings.Default.Modifiers.Split(' '))
                m_symbolTable.Add(symbol, types[1]);

            foreach (string symbol in Settings.Default.Operators.Split(' '))
                m_symbolTable.Add(symbol, types[2]);
        }

        public SourceObject Scan(SourceFile sourceFile)
        {
            Regex curRE = m_defRE;
            SourceObject srcObj = sourceFile;   // Scan just returns the supplied SourceFile as a SourceObject
            SourceObject sequence = sourceFile;  // begin the sequence creation from this SourceFile object
            string[] lines = sourceFile.GetAllSourceLines();
            foreach(string line in lines)
            {
                int p = 0;
                int len = line.Length;
                do
                {
                    Match match = curRE.Match(line, p);
                    p = match.Index + match.Length;
                    GetToken(match, out string type, out string token);
                    sequence = ProcessToken(type, token, sequence, ref curRE);


                } while (p < len);                                                                                                                        
            }

            return srcObj;
        }

        // TODO: add error handling if Match.Success = false or no group found
        private static readonly string[] s_types = { "identifier", "ws", "symbol", "comment", "string", "blank", "preprocessor" };
        private void GetToken(Match match, out string type, out string value)
        {
            foreach(string name in s_types)
            {
                Group grp = match.Groups[name];
                if (grp.Success)
                {
                    type = name;
                    value = grp.Value;
                    return;
                }
            }
            type = "ERROR";
            value = "";
        }

        private SourceObject ProcessToken(string type, string token, SourceObject sequence, ref Regex curRE)
        {
            TRecord record;
            switch(type)
            {
                case "identifier":
                    record = m_symbolTable.FindOrAdd(token, m_typeList[3]);
                    sequence.LinkNext(CreateSourceObject(record));
                    sequence = sequence.Sequence;
                    break;

                case "ws":
                    // ignored for now
                    break;

                case "symbol":
                    sequence = IndentifyOperators(token, sequence);
                    break;

                case "comment":
                    break;

                case "string":
                    break;

                case "blank":
                    break;

                case "preprocessor":
                    break;
            }

            return sequence;
        }

        public SourceObject IndentifyOperators(string token, SourceObject srcObj)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new InvalidOperationException("Could not identify symbol!\nSee inner exception.",
                    new ArgumentException("Parameter cannot be null, Empty or Whitespace!", nameof(token)));

            int p = 0;
            int len = token.Length;
            do
            {
                if (m_symbolTable.TryFind(token.Substring(p, len), out TRecord record))
                {
                    srcObj.LinkNext(CreateSourceObject(record));
                    srcObj = srcObj.Sequence;
                    p += len;
                    len = token.Length - p;
                }
                else
                    len--;

            } while (len > 0);

            if(p < token.Length)   // this indicates that a (portion) of the token was not identified
            {
                srcObj.LinkNext(new ErrorObj($"@:{token.Substring(p, token.Length-p)}"));    // HACK: create an error/warn/info system with sensible codes
                srcObj = srcObj.Sequence;
            }

            return srcObj;
        }

    }
}
