using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public enum SourceType
    {
        // Used for when Source (esp. Struct) type not known and being Identified etc.
        Null, Unknown, Identifying = Unknown, 
        
        // Used for Source Structure types
        Using, NamespaceDeclr, Class, Struct, Delegate, Block,

        // used for Source Object types
        Namespace, QName, Modifiers
    }
}
