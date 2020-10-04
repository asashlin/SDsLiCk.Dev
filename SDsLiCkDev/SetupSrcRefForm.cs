using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDsLiCk.Dev.Properties;

namespace SDsLiCk.Dev
{
    public partial class SetupSrcRefForm : Form
    {
        private int m_selectedIdx = -1;
        private string[] m_slnList;
        private readonly Dictionary<string, FileRef> m_selectedFiles = new Dictionary<string, FileRef>();


        public string WorkingDirectory { get => c_txtlWrkngDir.Text; set => c_txtlWrkngDir.Text = value; }

        public SetupSrcRefForm()
        {
            InitializeComponent();

            c_cmbSolutions.Text = "Select Browse to find Solution File!";
        }

        private void c_butBrowseWD_Click(object sender, EventArgs e)
        {
            c_dlgfolderBrowser.SelectedPath = Settings.Default.LastWorkingDir;
            DialogResult response = c_dlgfolderBrowser.ShowDialog();
            if (response == DialogResult.OK)
            {
                Settings.Default.LastWorkingDir = c_dlgfolderBrowser.SelectedPath;
                c_txtlWrkngDir.Text = c_dlgfolderBrowser.SelectedPath;

                FindSolutions();
                FindProjects();
                FindSourceFiles();
            }
        }

        private void FindSolutions()
        {
            string name;
            m_slnList = Directory.GetFiles(WorkingDirectory, "*.sln");
            c_cmbSolutions.Items.Clear();
            switch (m_slnList.Length)
            {
                case 0:
                    m_selectedIdx = -1; // no soltuions avaialble to select
                    c_cmbSolutions.Text = "No C# Solution File found!";
                    break;

                case 1:
                    m_selectedIdx = 0;   // solution selected
                    name = Path.GetFileNameWithoutExtension(m_slnList[0]);
                    c_cmbSolutions.Items.Add(name);
                    c_cmbSolutions.SelectedIndex = 0;
                    break;

                default:
                    m_selectedIdx = -1;   // solution not selected yet.
                    foreach (string sln in m_slnList)
                    {
                        name = Path.GetFileNameWithoutExtension(sln);
                        c_cmbSolutions.Items.Add(name);
                    }
                    c_cmbSolutions.Text = "Select a Solution File from DropDown!";
                    break;
            }
        }

        private void FindProjects()
        {
            if (m_selectedIdx != -1)
            {            
                string slnpath = m_slnList[m_selectedIdx];
                string[] prjFiles = Directory.GetFiles(Path.GetDirectoryName(slnpath), "*.csproj", SearchOption.AllDirectories);
                foreach(string prj in prjFiles)
                {
                    string name = Path.GetFileNameWithoutExtension(prj);
                    ListViewItem lviPrj =  c_lvProjects.Items.Add(name);
                    lviPrj.SubItems.Add(Path.GetFileNameWithoutExtension(slnpath));
                    lviPrj.SubItems.Add(prj);
                }
            }
        }

        private void FindSourceFiles()
        {
            //throw new NotImplementedException();
        }


    }
}
