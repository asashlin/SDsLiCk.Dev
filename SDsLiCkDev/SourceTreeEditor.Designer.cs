namespace SDsLiCk.Dev
{
    partial class SourceTreeEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c_tvSourceEditor = new System.Windows.Forms.TreeView();
            this.c_mnuSrcEditor = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c_mniFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c_mniSrcSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.c_dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.c_mnuSrcEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_tvSourceEditor
            // 
            this.c_tvSourceEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_tvSourceEditor.Location = new System.Drawing.Point(0, 31);
            this.c_tvSourceEditor.Name = "c_tvSourceEditor";
            this.c_tvSourceEditor.Size = new System.Drawing.Size(449, 352);
            this.c_tvSourceEditor.TabIndex = 0;
            // 
            // c_mnuSrcEditor
            // 
            this.c_mnuSrcEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sourceToolStripMenuItem});
            this.c_mnuSrcEditor.Location = new System.Drawing.Point(0, 0);
            this.c_mnuSrcEditor.Name = "c_mnuSrcEditor";
            this.c_mnuSrcEditor.Size = new System.Drawing.Size(449, 24);
            this.c_mnuSrcEditor.TabIndex = 1;
            this.c_mnuSrcEditor.Text = "mnuSrcEditor";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_mniFileOpen,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.newToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // c_mniFileOpen
            // 
            this.c_mniFileOpen.Name = "c_mniFileOpen";
            this.c_mniFileOpen.Size = new System.Drawing.Size(103, 22);
            this.c_mniFileOpen.Text = "Open";
            this.c_mniFileOpen.Click += new System.EventHandler(this.c_mniFileOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // sourceToolStripMenuItem
            // 
            this.sourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c_mniSrcSetup,
            this.addClassToolStripMenuItem,
            this.addInterfaceToolStripMenuItem});
            this.sourceToolStripMenuItem.Name = "sourceToolStripMenuItem";
            this.sourceToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sourceToolStripMenuItem.Text = "Source";
            // 
            // c_mniSrcSetup
            // 
            this.c_mniSrcSetup.Name = "c_mniSrcSetup";
            this.c_mniSrcSetup.Size = new System.Drawing.Size(145, 22);
            this.c_mniSrcSetup.Text = "Set up";
            this.c_mniSrcSetup.Click += new System.EventHandler(this.c_mniSrcSetup_Click);
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addClassToolStripMenuItem.Text = "Add class";
            // 
            // addInterfaceToolStripMenuItem
            // 
            this.addInterfaceToolStripMenuItem.Name = "addInterfaceToolStripMenuItem";
            this.addInterfaceToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addInterfaceToolStripMenuItem.Text = "Add interface";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(371, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // c_dlgOpenFile
            // 
            this.c_dlgOpenFile.DefaultExt = "xml";
            this.c_dlgOpenFile.FileName = "source.xml";
            this.c_dlgOpenFile.Filter = "XML File | *.xml";
            this.c_dlgOpenFile.Multiselect = true;
            this.c_dlgOpenFile.Title = "Select Simple Source XML file";
            this.c_dlgOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.c_dlgOpenFile_FileOk);
            // 
            // SourceTreeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_tvSourceEditor);
            this.Controls.Add(this.c_mnuSrcEditor);
            this.Name = "SourceTreeEditor";
            this.Size = new System.Drawing.Size(449, 420);
            this.c_mnuSrcEditor.ResumeLayout(false);
            this.c_mnuSrcEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView c_tvSourceEditor;
        private System.Windows.Forms.MenuStrip c_mnuSrcEditor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c_mniFileOpen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog c_dlgOpenFile;
        private System.Windows.Forms.ToolStripMenuItem sourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c_mniSrcSetup;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addInterfaceToolStripMenuItem;
    }
}
