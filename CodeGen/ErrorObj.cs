using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class ErrorObj : SourceObject
    {
        public ErrorObj(string prefix, int code)
            : base(prefix + code, TokenRef.Type.Error)
        { }

        // TODO: add formatting as get 4 code digits i.e. "CS" + 1 -> "CS0001"
        public ErrorObj(string code)
            : base(code, TokenRef.Type.Error)
        { }
    }
}