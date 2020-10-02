using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
	public class SourceObject
	{
		public TokenRef.Type OfType { get; }
		public string Text { get; }
        public SourceObject Sequence { get; private set; }
        public SourceObject Previous { get; private set; }

        public SourceObject(string text, TokenRef.Type type)
		{
			OfType = type;
			Text = text;
            Sequence = null;
            Previous = null;
        }
		
		public void LinkNext(SourceObject srcObj)
		{
            if (Sequence == null)
            {
                Sequence = srcObj;
                srcObj.Previous = this;
            }

            else
                Sequence.LinkNext(srcObj);   // find the current end of the list
		}
		
		public void InsertNextLink(SourceObject srcObj)
		{
            if (Sequence == null)
            {
                Sequence = srcObj;           // at the end of the list -add object here
                srcObj.Previous = this;
            }

            else
            {
                srcObj.Previous = this;
                SourceObject oldNext = Sequence;
                Sequence = srcObj;
                srcObj.LinkNext(oldNext);   // find the current end of the inserted list and link the old next object there to complete Sequence
            }
		}

        public override string ToString()
        {
            return $"SourceObject: Type-{OfType.ToString()}, Text-{Text}";
        }
    }
}