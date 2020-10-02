using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace IBA.SDsLiCk.CodeGen
{
	public class SourceRef
	{
        //private StructBldr m_structBldr;
        public SourceFile[] FileList { get; private set; }
 
        public SourceRef(FileRef srcFile)
		{
            FileList = new SourceFile[1];
			FileList[0] = new SourceFile(srcFile, SourceFile.Type.Source);
        }
		
	    public SourceRef(FileRef srcFile, FileRef dsgnrFile, FileRef resxFile)
		{
            FileList = new SourceFile[3];
			FileList[0] = new SourceFile(srcFile, SourceFile.Type.Form);
			FileList[1] = new SourceFile(dsgnrFile, SourceFile.Type.Designer);
			FileList[2] = new SourceFile(resxFile, SourceFile.Type.Resource);
        }

        public SourceRef(params FileRef[] srcFiles)
		{
            int len = srcFiles.Length;
			FileList = new SourceFile[len];
			for(int i = 0; i < len; i++)
				FileList[i] = new SourceFile(srcFiles[i], SourceFile.Type.Source);
        }

	}
}