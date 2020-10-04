using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using IBA.SDsLiCk.CodeGen;
using IBA.SDsLiCk.CodeGen.CS;

namespace IBA.SDsLiCk.GUIBuilder
{
    public partial class CtrlParser
    {
        public SourceRef SourceReference { get; }
        private CSScanner<SymbolRecord, TokenRef.Type> m_scanner;

        public CtrlParser(FileRef filepath)
        {
            m_scanner = new CSScanner<SymbolRecord, TokenRef.Type>(CreateSymbol, CreateSourceObject, new TokenRef.Type[] { TokenRef.Type.Keyword, TokenRef.Type.Modifier, TokenRef.Type.Operator, TokenRef.Type.Identifier } );

            if (!filepath.IsAbsoluteFilepath)
                throw new ArgumentException($"Absolute Filepath required! ", nameof(filepath));

            FileRef designer = filepath.CreateWith("Designer.cs");
            FileRef resource = filepath.CreateWith("resx");

            SourceReference = new SourceRef(filepath, designer, resource);
            int i = 0;
            foreach (SourceFile srcFile in SourceReference.FileList)
            {
                SourceObject srcObj = m_scanner.Scan(srcFile);                   // After call, SourceObj sequence will be available through m_srcRef.FileList[n] (.Sequence)

#if DEBUG
                srcObj = srcFile.Sequence;
                Debug.Write("", srcFile.Text);
                while (srcObj != null)
                {
                    Debug.Write(srcObj.Text + " ");
                    srcObj = srcObj.Sequence;
                }
                Debug.WriteLine("");
#endif

            }
        }

        public void Parse()
        {
            foreach (SourceFile srcFile in SourceReference.FileList)
            {
                srcFile.SourceStruct.LinkNext(Parse(srcFile));
            }
        }

        public SourceStruct Parse(SourceFile srcFile)
        {
            SourceStruct srcBuilder = null;
            while (srcFile.Sequence != null)
            {
                srcBuilder = StructBldr.Build(srcFile);
            }
            return srcBuilder;
        }

        private SymbolRecord CreateSymbol(string token, TokenRef.Type type)
        {
            return new SymbolRecord(token, type);
        }

        private SourceObject CreateSourceObject(SymbolRecord record)
        {
            SourceObject srcObj;
            switch (record.Type)
            {
                case TokenRef.Type.Keyword:
                case TokenRef.Type.Modifier:
                case TokenRef.Type.Identifier:
                case TokenRef.Type.Operator:
                    srcObj = new SourceObject(record.Token, record.Type);
                    break;

                default:
                    throw InvalidEnumValueException.InvalidArgument(typeof(TokenRef.Type), record.Type, nameof(record.Type));
            }
            return srcObj;
        }

    }
}