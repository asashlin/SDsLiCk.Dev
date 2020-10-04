using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBA.SDsLiCk.GUIBuilder;
using SDsLiCk.Dev.Properties;

namespace SDsLiCk.Dev
{
    public partial class LauncherForm : Form
    {
        private readonly Dictionary<string, string> m_formList = new Dictionary<string, string>();

        public LauncherForm()
        {
            InitializeComponent();

            // HACK: hardwired for now
            m_formList.Add("IBA.SDsLiCk.CodeGen.Simple", @"D:\Users\Tony\MyProjects\IBA\SDsLiCk\SDsLiCk\CodeGen\Simple.cs");
            m_formList.Add("SDsLiCk.Dev.LauncherForm", @"D:\Users\Tony\MyProjects\IBA\SDsLiCk\SDsLiCk.Dev\SDsLiCkDev\LauncherForm.cs");
            c_clbForms.Items.Add("IBA.SDsLiCk.CodeGen.Simple", true);
            c_clbForms.Items.Add("SDsLiCk.Dev.LauncherForm", false);
            //CtrlParser.GenerateGDTree(c_tvGDTree);  used for CtrlParser using XBldr
            if (Settings.Default.LastWorkingDir == string.Empty)
                Settings.Default.LastWorkingDir = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        }

        private void c_butAnalyse_Click(object sender, EventArgs e)
        {
            CtrlParser parser;
            foreach (int idx in c_clbForms.CheckedIndices)
            {
                string name = (string)c_clbForms.Items[idx];
                FileRef filepath = m_formList[name];
                parser = new CtrlParser(filepath);
                parser.Parse();
            }
        }

        private void c_butTEST_Click(object sender, EventArgs e)
        {
            //SourceObject test1 = new SourceObject("L1", SourceObject.Type.String);
            //SourceObject test2 = new SourceObject("L2", SourceObject.Type.String);
            //SourceObject test3 = new SourceObject("L3", SourceObject.Type.String);
            //SourceObject test4 = new SourceObject("L4", SourceObject.Type.String);
            //SourceObject test5 = new SourceObject("I5", SourceObject.Type.String);
            //SourceObject test6 = new SourceObject("I6", SourceObject.Type.String);
            //SourceObject test7 = new SourceObject("I7", SourceObject.Type.String);


            //test1.LinkNext(test2);
            //test1.LinkNext(test3);
            //test3.LinkNext(test4);

            //test6.LinkNext(test7);

            //test4.InsertNextLink(test5);
            //test2.InsertNextLink(test6);

            //SourceObject test  = test1;
            //Debug.Write(test.Text + " ", "Forward Test");
            //while (test.Sequence != null)
            //{
            //    test = test.Sequence;
            //    Debug.Write(test.Text + " ");
            //}

            //Debug.WriteLine("");

            //Debug.Write(test.Text + " ", "Previous Test");
            //while (test.Previous != null)
            //{
            //    test = test.Previous;
            //    Debug.Write(test.Text + " ");
            //}

            //Debug.WriteLine("");
        }

        private void LauncherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
