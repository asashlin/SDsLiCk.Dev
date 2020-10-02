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
        private struct NSRecRef
        {
            internal int SeqNo { get; }
            internal string Identifier { get; }
            internal string Sequence { get; }
            internal string Alternate { get; }

            internal NSRecRef(int seqNo, string identifier, string sequence, string alternate) : this()
            {
                SeqNo = seqNo;
                Identifier = identifier;
                Sequence = sequence;
                Alternate = alternate;
            }

            public NSRecRef(int seqNo, string identifier) : this()
            {
                SeqNo = seqNo;
                Identifier = identifier;
                Sequence = null;
                Alternate = null;
            }

            public static bool operator ==(NSRecRef ref1, NSRecRef ref2) => ref1.Identifier == ref2.Identifier && ref1.SeqNo == ref2.SeqNo;

            public static bool operator !=(NSRecRef ref1, NSRecRef ref2) => ref1.Identifier != ref2.Identifier || ref1.SeqNo != ref2.SeqNo;

            public override bool Equals(object obj)
            {
                if (obj == null)
                    throw new ArgumentNullException(nameof(obj));

                if (!(obj is NSRecRef))
                    throw new ArgumentException("Not an 'NSRecRef' object!", $"{nameof(obj)}");

                return Identifier == ((NSRecRef)obj).Identifier && SeqNo == ((NSRecRef)obj).SeqNo;
            }

#warning Does GetHashCode() return same value for same SeqNo when both Name = null and Name = Empty -if so need to fix -maybe return -1 to invert when null
            public override int GetHashCode() => SeqNo.GetHashCode() ^ Identifier?.GetHashCode() ?? -1;       // if 'Identifier' is null, then the RHS = '0' (and the HashCode is effectively based on SeqNo). 

            public static int ExtractReference(ref string objRef)
            {
                int seqNo;
                int p = objRef.IndexOf('#');
                if (p == -1)
                    seqNo = 0;           // no explicit sequence no. Return implicit 0.

                else
                {
                    objRef = objRef.Substring(0, p);
                    if (p == objRef.Length - 1)         // i.e. 'obj' endes in a '#' only
                        throw new FormatException($"The char '#' is only used to denote a sequence number and cannot end a Object Reference as '{objRef}'!");

                    if (!int.TryParse(objRef.Substring(p + 1), out seqNo))
                        throw new FormatException($"The char '#' is only used to denote a sequence number and the value '{objRef.Substring(p)}' does not equate to a number as Object Reference '{objRef}'!");
                }

                return seqNo;
            }
        }
    }
}