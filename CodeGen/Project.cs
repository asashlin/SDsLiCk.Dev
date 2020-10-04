using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class Project : SourceRef
    {
        public Project(string name)
            : base(name, name + ".csprj",SourceFile.Type.Project)
        {
        }
    }
}