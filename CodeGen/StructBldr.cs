using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using IBA.SDsLiCk.CodeGen;

namespace IBA.SDsLiCk.CodeGen
{
   
    public static class StructBldr
    {
        public static NextStateFunc NextStateFunc { get; private set; }

        public static void SetNextStateFunc(NextStateFunc nextStateFunc)
        {
            NextStateFunc = nextStateFunc;
        }

        public static SourceStruct Build(SourceFile srcFile)
        {
            SourceObject start = srcFile.Sequence;     // the start object in a sequence of Struct objects to process           
            SourceObject next = start;                 // the next object to process
            SourceStruct first = null;                 // the 1st struct built upon this call
            SourceStruct previous, build = null;

            ParseResponse response = NextStateFunc.GoToNextState(next);
            do
            {

            } while (response != ParseResponse.Null);

            return first;
        }

        private static SourceStruct.Type IdentifyType(ref SourceObject next, out SourceObject end)
        {
            SourceStruct.Type ofType = SourceStruct.Type.Identifying;    // if not changed, this value indicates that could not be identified
            switch (next.OfType)
            {
                case TokenRef.Type.Keyword when next.Text == "using":
                    ofType = SourceStruct.Type.Using;
                    break;

                default:
                    throw new InvalidOperationException($"Could not identify {next.ToString()}!");
            }

            end = next.Sequence;
            return ofType;
        }
    }
}