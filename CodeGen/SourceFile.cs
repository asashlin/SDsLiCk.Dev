using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
    public class SourceFile : SourceObject
    {
        public new enum Type
        {
            Null, Source, Form, UserControl, Designer, Resource, Other,
            Project,
            Solution
        }

        public FileRef Filepath { get; }
        public new Type OfType { get; }         // SourceObject.Type is hidden as not required by SourceFile (which defines it as ObjType.Null and is accesible as "base.Type")

        public SourceStruct SourceStruct { get; private set; }
        private SourceStruct m_lastStruct = null;    // used to remember last structure created for use in linking more

        public SourceFile(FileRef filepath, Type type)
            : base(filepath.Filename, TokenRef.Type.Non)
        {
            Debug.Assert(type != Type.Null, "Cannot be of Type.Null");
            Filepath = filepath;
            OfType = type;
            SourceStruct = null;
        }

        public string[] GetAllSourceLines()
        {
            if (OfType == Type.Form || OfType == Type.UserControl || OfType == Type.Designer || OfType == Type.Source)
                return File.ReadAllLines(Filepath);

            else
                return new string[0];   // return empty list
        }
        public void AddStruct(SourceStruct sourceStruct)
        {
            m_lastStruct.LinkNext(sourceStruct);
            m_lastStruct = sourceStruct;
        }


        // TODO: add more file type read varieties
    }
}