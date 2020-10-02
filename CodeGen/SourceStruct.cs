using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    /// <summary>Base class for various SourceStructs, including SourceContainer derived classes</summary>
    /// <remarks>
    /// Is base to SourceContainer and SourceStruct and SourceContainer dervived clases are collectively known as SourceStruct...
    /// </remarks>
    public abstract class SourceStruct : SourceSnippet
    {
        public enum Type
        {
            Null, Unknown, Identifying = Unknown, Using, NamespaceDeclr, Class, Struct, Delegate, Block,
            Namespace, QName, Modifiers
        }

        public SourceStruct Next { get; private set; }
        public SourceFile File { get; }

        protected SourceStruct(string name, SourceObject start, Type type, SourceFile srcFile)
            : base(name, start, type)
        {
            Next = null;
            File = srcFile;
        }

        protected SourceStruct(SourceObject start, Type type, SourceFile srcFile)
            : base(start, type)
        {
            Next = null;
            File = srcFile;
        }

        public void LinkNext(SourceStruct srcStruct)
        {
            if (Next == null)
                Next = srcStruct;

            else
                Next.LinkNext(srcStruct);   // find the current end of the list

        }

        public virtual void SetChild(SourceStruct srcStruct)
        {
            throw new InvalidOperationException($"Can't set child for a 'SourceStruct Object -must be a SourceContainer!\nThis object: {this}, of type: {OfType.ToString()}");
        }
    }
}