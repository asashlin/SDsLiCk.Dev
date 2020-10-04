using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDsLiCk.Dev;
using SDsLiCk.Dev.Properties;

namespace SDsLiCk.Dev
{
    public partial class SourceTreeEditor : UserControl
    {
        public SourceTreeEditor()
        {
            InitializeComponent();
        }

        private void c_mniFileOpen_Click(object sender, EventArgs e)
        {

        }

        private void c_mniSrcSetup_Click(object sender, EventArgs e)
        {
            SetupSrcRefForm dlg = new SetupSrcRefForm
            {
                WorkingDirectory = Settings.Default.LastWorkingDir
            };

            DialogResult result = dlg.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }

        private void c_dlgOpenFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
