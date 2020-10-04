using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    /// <summary>
    /// Base for; 1. a Source Snippet used as components to SourceStructs, 2.
    /// SourceStruct class (and their derived classes)
    /// </summary>
    public abstract class SourceSnippet
    {
        public SourceObject End { get; set; }    // the object that ends (terminates) this SourceStruct -it also holds the last object processed until the structure is completed
        public SourceType OfType { get; }
        public string Name { get; protected set; }
        public SourceObject Sequence { get; protected set; }

        protected SourceSnippet(SourceType type, SourceObject start)
        {
            OfType = type;
            Name = "";              // name maybe set by inherited class 
            Sequence = start;
            End = null;          // designates an empty Struct -e.g. a QName without a Namespace
        }

        protected SourceSnippet(string name, SourceType type, SourceObject start)
        {
            OfType = type;
            Name = name;              // name maybe set by inherited class 
            Sequence = start;
            End = null;          // designates an empty Struct -e.g. a QName without a Namespace
        }

        protected SourceSnippet(SourceObject start, SourceType type)
        {
            OfType = type;
            Name = "";              // name maybe set by inherited class 
            Sequence = start;
        }

        protected SourceSnippet(string name, SourceObject start, SourceType type)
        {
            OfType = type;
            Name = name;
            Sequence = start;
        }

        protected SourceSnippet(SourceObject start, SourceObject end, SourceType type)
        {
            OfType = type;
            Name = "";              // name maybe set by inherited class 
            Sequence = start;
            End = end;

        }

        protected SourceSnippet(string name, SourceObject start, SourceObject end, SourceType type)
        {
            OfType = type;
            Name = name;
            Sequence = start;
            End = end;
        }

        public bool IsEmpty => End == null;    // End == to null designates an empty SourceSnippet Object 

    }
}