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
        private static NextStateBuilder NSBldr { get; }
        public static NextStateFunc NextStateFunc { get; }

        static CtrlParser()
        {
            NextStateRec nsStart = NextStateRec.CreateGrammaDef("Start");
            NSBldr = new NextStateBuilder(nsStart, OnParserAction);
            Initialise(nsStart);
            NextStateFunc = NSBldr.NextStateFunc;
            StructBldr.SetNextStateFunc(NextStateFunc);
        }

        private static bool OnParserAction(string action)
        {
            throw new NotImplementedException();
        }

        private static void Initialise(NextStateRec nsStart)
        {
            NextStateRec nsRec1, nsRec2, nsRec3, nsRec4, nsRec5, nsRec6;

            // create the Definition Next States and assign Start state
            NextStateRec nsUsingDir = NextStateRec.CreateGrammaDef("UsingDir");
            NextStateRec nsNamespaceDec = NextStateRec.CreateGrammaDef("NamespaceDec");
            NextStateRec nsNamespace = NextStateRec.CreateGrammaDef("Namespace");

            // Build the 'Start' definition NS sequence
            nsRec1 = NextStateRec.CreateGrammaRef("UsingDir");
            nsRec2 = NextStateRec.CreateGrammaRef("NamespaceDec");
            nsRec3 = NextStateRec.CreateEmpty(ParseResponse.Accept);
            NSBldr.AddSequenceNSRecord(nsStart, nsRec1);         // Seq: Start > UsingDir 
            NSBldr.AddSequenceNSRecord(nsRec1, nsRec1);          // Seq: UsingDir > UsingDir 
            NSBldr.AddAlternativeNSRecord(nsRec1, nsRec2);       // Alt: UsingDir > NamespaceDec
            NSBldr.AddSequenceNSRecord(nsRec2, nsRec1);          // Seq: NamespaceDec > UsingDir
            NSBldr.AddAlternativeNSRecord(nsRec2, nsRec3);       // Alt: NamespaceDec > &Empty

            // Begin the 'using' Directive NS sequence 
            nsRec1 = NextStateRec.CreateTokenRef("using", TokenRef.Type.Keyword);
            nsRec2 = NextStateRec.CreateGrammaRef("Namespace");
            nsRec3 = NextStateRec.CreateTokenRef(";", TokenRef.Type.Operator, ParseResponse.Accept);
            NSBldr.AddSequenceNSRecord(nsUsingDir, nsRec1);      // Seq: UsingDir > "Using" 
            NSBldr.AddSequenceNSRecord(nsRec1, nsRec2);          // Seq: "Using" > Namespace 
            NSBldr.AddSequenceNSRecord(nsRec2, nsRec3);          // Seq: Namespace > ';'      Accept gramma -no sequence required

            // Begin the Namespace NS sequence 
            nsRec1 = NextStateRec.CreateTokenRef(TokenRef.Type.Identifier, ParseResponse.Append);
            nsRec2 = NextStateRec.CreateTokenRef(".", TokenRef.Type.Operator, ParseResponse.Append);
            nsRec3 = NextStateRec.CreateEmpty(ParseResponse.Accept);
            NSBldr.AddSequenceNSRecord(nsNamespace, nsRec1);      // Seq: UsingDir > &Identifier 
            NSBldr.AddSequenceNSRecord(nsRec1, nsRec2);           // Seq: '.' > Namespace 
            NSBldr.AddSequenceNSRecord(nsRec2, nsRec3);          // Seq: Namespace > ';'      Accept gramma -no sequence required

            //nsRec4 = NextStateRec.CreateTokenRef(TokenRef.Type.Identifier);
            //nsRec5 = NextStateRec.CreateTokenRef(".", TokenRef.Type.Operator);
            //nsRec6 = NextStateRec.CreateTokenRef(";", TokenRef.Type.Operator, ParseResponse.Accept);
            //NSBldr.AddSequenceNSRecord(nsRec1, nsRec2);
            //ns
        }

    }
}