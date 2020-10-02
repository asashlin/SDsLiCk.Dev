using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using IBA.SDsLiCk.CodeGen;

namespace IBA.SDsLiCk.CodeGen
{
    public class StructBldr
    {
        private enum BuildInstr
        {
            Continue, Done, Stack, Complete
        }

        private NextStateFunc NextStateFunc { get; }

        public StructBldr(NextStateFunc nextStateFunc)
        {
            NextStateFunc = nextStateFunc;
        }

        /// <summary>Build the SourceStruct using the SoucreObject sequence from a SourceFile</summary>
        /// <param name="lastSrcStruct">Ref: loaded with the last SourceStruct created previously or null if none. Gets set to the last created this call</param>
        /// <param name="srcFile">The SourceFile to use for building the SourceStruct from</param>
        /// <returns>The 1st SourceStruct created by this call ...</returns>
        internal SourceStruct Build(ref SourceStruct lastSrcStruct, SourceFile srcFile)
        {
            BuildInstr instr = BuildInstr.Continue;    // continue until a struct is identified
            SourceObject start = srcFile.Sequence;     // the start object in a sequence of Struct objects to process           
            SourceObject next = start;                 // the next object to process
            SourceStruct first = null;                 // the 1st struct built upon this call
            SourceStruct previous, build = null;

            NextStateFunc.BeginParse();
            while (next != null)
            {
                ParseResponse response = NextStateFunc.GoToNextState(next);
                switch (response)
                {
                    case ParseResponse.Accept:
                        if (first == null)
                            first = build;
                        break;

                    case ParseResponse.Resume:
                        break;

                    case ParseResponse.Next:
                    case ParseResponse.Call:
                        next = next.Sequence;
                        break;

                    default:
                        throw new InvalidEnumValueException(typeof(ParseResponse), response);
                }
            }

            // TODO: add check for source file completion, i.e. nothing left on the stack

            return first;
        }

    }
}