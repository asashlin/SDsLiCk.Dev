using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using IBA.SDsLiCk.CodeGen;

namespace IBA.SDsLiCk.GUIBuilder
{
    partial class CtrlParser
    {
        internal struct SymbolRecord
        {
            internal string Token { get; }
            internal TokenRef.Type Type { get; }

            public SymbolRecord(string token, TokenRef.Type type) : this()
            {
                Token = token ?? throw new ArgumentNullException(nameof(token));
                Type = type;
            }
       }
    }
}