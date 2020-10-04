using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class Solution : SourceRef
    {
        private readonly Dictionary<string, Project> m_projects = new Dictionary<string, Project>();


        public Solution(string name)
            : base(name, name + ".sln", SourceFile.Type.Solution)
        {
        }

        public Project[] Projects
        {
            get => throw new NotImplementedException();
        }

        public Project GetProject(string name)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int index)
        {
            throw new NotImplementedException();
        }

    }
}