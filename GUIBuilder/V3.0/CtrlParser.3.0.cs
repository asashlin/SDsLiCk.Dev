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
        private SourceRef m_srcRef;
        private CSScanner<SymbolRecord, TokenRef.Type> m_scanner;

        public CtrlParser(FileRef filepath)
        {
            m_scanner = new CSScanner<SymbolRecord, TokenRef.Type>(CreateSymbol, CreateSourceObject, new TokenRef.Type[] { TokenRef.Type.Keyword, TokenRef.Type.Modifier, TokenRef.Type.Operator, TokenRef.Type.Identifier } );

            if (!filepath.IsAbsoluteFilepath)
                throw new ArgumentException($"Absolute Filepath required! ", nameof(filepath));

            FileRef designer = filepath.CreateAs("Designer.cs");
            FileRef resource = filepath.CreateAs("resx");

            m_srcRef = new SourceRef(filepath, designer, resource);
            int i = 0;
            foreach (SourceFile srcFile in m_srcRef.FileList)
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
        private static Regex s_curr_RE = s_FILE_RE;
        private static Regex s_FILE_RE = new Regex("");
        private SourceStruct Parse(SourceFile srcFile)
        {
            throw new NotImplementedException();
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