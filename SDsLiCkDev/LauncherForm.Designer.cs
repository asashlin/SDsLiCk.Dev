namespace SDsLiCk.Dev
{
    partial class LauncherForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.c_tcProject = new System.Windows.Forms.TabControl();
            this.c_tpFormAnalyser = new System.Windows.Forms.TabPage();
            this.c_butTEST = new System.Windows.Forms.Button();
            this.c_lblForms = new System.Windows.Forms.Label();
            this.c_clbForms = new System.Windows.Forms.CheckedListBox();
            this.c_butAnalyse = new System.Windows.Forms.Button();
            this.c_tpGUIBldr = new System.Windows.Forms.TabPage();
            this.c_pnlCtrlHlder = new System.Windows.Forms.Panel();
            this.c_tpSrcTreeEditor = new System.Windows.Forms.TabPage();
            this.c_splGUIBldr = new System.Windows.Forms.SplitContainer();
            this.sourceTreeEditor1 = new SDsLiCk.Dev.SourceTreeEditor();
            this.c_tpGDTree = new System.Windows.Forms.TabPage();
            this.c_tvGDTree = new System.Windows.Forms.TreeView();
            this.c_ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.c_tpParseTree = new System.Windows.Forms.TabPage();
            this.c_tvParseTree = new System.Windows.Forms.TreeView();
            this.c_tcProject.SuspendLayout();
            this.c_tpFormAnalyser.SuspendLayout();
            this.c_tpGUIBldr.SuspendLayout();
            this.c_tpSrcTreeEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_splGUIBldr)).BeginInit();
            this.c_splGUIBldr.Panel1.SuspendLayout();
            this.c_splGUIBldr.SuspendLayout();
            this.c_tpGDTree.SuspendLayout();
            this.c_tpParseTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_tcProject
            // 
            this.c_tcProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_tcProject.Controls.Add(this.c_tpFormAnalyser);
            this.c_tcProject.Controls.Add(this.c_tpGUIBldr);
            this.c_tcProject.Controls.Add(this.c_tpSrcTreeEditor);
            this.c_tcProject.Controls.Add(this.c_tpGDTree);
            this.c_tcProject.Controls.Add(this.c_tpParseTree);
            this.c_tcProject.Location = new System.Drawing.Point(13, 13);
            this.c_tcProject.Name = "c_tcProject";
            this.c_tcProject.SelectedIndex = 0;
            this.c_tcProject.Size = new System.Drawing.Size(814, 500);
            this.c_tcProject.TabIndex = 0;
            // 
            // c_tpFormAnalyser
            // 
            this.c_tpFormAnalyser.BackColor = System.Drawing.SystemColors.Control;
            this.c_tpFormAnalyser.Controls.Add(this.c_butTEST);
            this.c_tpFormAnalyser.Controls.Add(this.c_lblForms);
            this.c_tpFormAnalyser.Controls.Add(this.c_clbForms);
            this.c_tpFormAnalyser.Controls.Add(this.c_butAnalyse);
            this.c_tpFormAnalyser.Location = new System.Drawing.Point(4, 22);
            this.c_tpFormAnalyser.Name = "c_tpFormAnalyser";
            this.c_tpFormAnalyser.Size = new System.Drawing.Size(806, 474);
            this.c_tpFormAnalyser.TabIndex = 1;
            this.c_tpFormAnalyser.Text = "Form Analyser";
            // 
            // c_butTEST
            // 
            this.c_butTEST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c_butTEST.Location = new System.Drawing.Point(109, 445);
            this.c_butTEST.Name = "c_butTEST";
            this.c_butTEST.Size = new System.Drawing.Size(75, 23);
            this.c_butTEST.TabIndex = 3;
            this.c_butTEST.Text = "TEST";
            this.c_butTEST.UseVisualStyleBackColor = true;
            this.c_butTEST.Click += new System.EventHandler(this.c_butTEST_Click);
            // 
            // c_lblForms
            // 
            this.c_lblForms.AutoSize = true;
            this.c_lblForms.Location = new System.Drawing.Point(15, 15);
            this.c_lblForms.Name = "c_lblForms";
            this.c_lblForms.Size = new System.Drawing.Size(78, 13);
            this.c_lblForms.TabIndex = 2;
            this.c_lblForms.Text = "Forms/Controls";
            // 
            // c_clbForms
            // 
            this.c_clbForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_clbForms.Location = new System.Drawing.Point(15, 29);
            this.c_clbForms.Name = "c_clbForms";
            this.c_clbForms.Size = new System.Drawing.Size(775, 409);
            this.c_clbForms.Sorted = true;
            this.c_clbForms.TabIndex = 1;
            this.c_clbForms.ThreeDCheckBoxes = true;
            this.c_clbForms.UseCompatibleTextRendering = true;
            // 
            // c_butAnalyse
            // 
            this.c_butAnalyse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c_butAnalyse.Location = new System.Drawing.Point(15, 445);
            this.c_butAnalyse.Name = "c_butAnalyse";
            this.c_butAnalyse.Size = new System.Drawing.Size(75, 23);
            this.c_butAnalyse.TabIndex = 0;
            this.c_butAnalyse.Text = "Analyse";
            this.c_butAnalyse.UseVisualStyleBackColor = true;
            this.c_butAnalyse.Click += new System.EventHandler(this.c_butAnalyse_Click);
            // 
            // c_tpGUIBldr
            // 
            this.c_tpGUIBldr.BackColor = System.Drawing.SystemColors.Control;
            this.c_tpGUIBldr.Controls.Add(this.c_pnlCtrlHlder);
            this.c_tpGUIBldr.Location = new System.Drawing.Point(4, 22);
            this.c_tpGUIBldr.Name = "c_tpGUIBldr";
            this.c_tpGUIBldr.Size = new System.Drawing.Size(806, 474);
            this.c_tpGUIBldr.TabIndex = 2;
            this.c_tpGUIBldr.Text = "GUIBldr";
            // 
            // c_pnlCtrlHlder
            // 
            this.c_pnlCtrlHlder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.c_pnlCtrlHlder.Location = new System.Drawing.Point(4, 4);
            this.c_pnlCtrlHlder.Name = "c_pnlCtrlHlder";
            this.c_pnlCtrlHlder.Size = new System.Drawing.Size(760, 392);
            this.c_pnlCtrlHlder.TabIndex = 0;
            // 
            // c_tpSrcTreeEditor
            // 
            this.c_tpSrcTreeEditor.BackColor = System.Drawing.SystemColors.Control;
            this.c_tpSrcTreeEditor.Controls.Add(this.c_splGUIBldr);
            this.c_tpSrcTreeEditor.Location = new System.Drawing.Point(4, 22);
            this.c_tpSrcTreeEditor.Name = "c_tpSrcTreeEditor";
            this.c_tpSrcTreeEditor.Padding = new System.Windows.Forms.Padding(3);
            this.c_tpSrcTreeEditor.Size = new System.Drawing.Size(806, 474);
            this.c_tpSrcTreeEditor.TabIndex = 0;
            this.c_tpSrcTreeEditor.Text = "SourceTree Editor";
            // 
            // c_splGUIBldr
            // 
            this.c_splGUIBldr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_splGUIBldr.Location = new System.Drawing.Point(3, 3);
            this.c_splGUIBldr.Name = "c_splGUIBldr";
            // 
            // c_splGUIBldr.Panel1
            // 
            this.c_splGUIBldr.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.c_splGUIBldr.Panel1.Controls.Add(this.sourceTreeEditor1);
            // 
            // c_splGUIBldr.Panel2
            // 
            this.c_splGUIBldr.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.c_splGUIBldr.Size = new System.Drawing.Size(800, 468);
            this.c_splGUIBldr.SplitterDistance = 511;
            this.c_splGUIBldr.TabIndex = 0;
            // 
            // sourceTreeEditor1
            // 
            this.sourceTreeEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTreeEditor1.BackColor = System.Drawing.SystemColors.Control;
            this.sourceTreeEditor1.Location = new System.Drawing.Point(0, -3);
            this.sourceTreeEditor1.Name = "sourceTreeEditor1";
            this.sourceTreeEditor1.Size = new System.Drawing.Size(511, 474);
            this.sourceTreeEditor1.TabIndex = 0;
            // 
            // c_tpGDTree
            // 
            this.c_tpGDTree.BackColor = System.Drawing.SystemColors.Control;
            this.c_tpGDTree.Controls.Add(this.c_tvGDTree);
            this.c_tpGDTree.Location = new System.Drawing.Point(4, 22);
            this.c_tpGDTree.Name = "c_tpGDTree";
            this.c_tpGDTree.Padding = new System.Windows.Forms.Padding(3);
            this.c_tpGDTree.Size = new System.Drawing.Size(806, 474);
            this.c_tpGDTree.TabIndex = 3;
            this.c_tpGDTree.Text = "GDef Tree";
            // 
            // c_tvGDTree
            // 
            this.c_tvGDTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_tvGDTree.ImageIndex = 0;
            this.c_tvGDTree.ImageList = this.c_ilIcons;
            this.c_tvGDTree.Location = new System.Drawing.Point(6, 6);
            this.c_tvGDTree.Name = "c_tvGDTree";
            this.c_tvGDTree.SelectedImageIndex = 0;
            this.c_tvGDTree.Size = new System.Drawing.Size(794, 462);
            this.c_tvGDTree.TabIndex = 1;
            // 
            // c_ilIcons
            // 
            this.c_ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("c_ilIcons.ImageStream")));
            this.c_ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.c_ilIcons.Images.SetKeyName(0, "Error");
            this.c_ilIcons.Images.SetKeyName(1, "Warning");
            this.c_ilIcons.Images.SetKeyName(2, "CSFile");
            this.c_ilIcons.Images.SetKeyName(3, "GrammaDef");
            this.c_ilIcons.Images.SetKeyName(4, "GrammaRef");
            this.c_ilIcons.Images.SetKeyName(5, "Optional");
            this.c_ilIcons.Images.SetKeyName(6, "List");
            this.c_ilIcons.Images.SetKeyName(7, "OptList");
            this.c_ilIcons.Images.SetKeyName(8, "Group");
            this.c_ilIcons.Images.SetKeyName(9, "AltBlock");
            this.c_ilIcons.Images.SetKeyName(10, "SeqBlock");
            this.c_ilIcons.Images.SetKeyName(11, "LoopBack");
            this.c_ilIcons.Images.SetKeyName(12, "Operator");
            this.c_ilIcons.Images.SetKeyName(13, "Keyword");
            this.c_ilIcons.Images.SetKeyName(14, "Symbol");
            this.c_ilIcons.Images.SetKeyName(15, "Action");
            this.c_ilIcons.Images.SetKeyName(16, "Empty");
            // 
            // c_tpParseTree
            // 
            this.c_tpParseTree.Controls.Add(this.c_tvParseTree);
            this.c_tpParseTree.Location = new System.Drawing.Point(4, 22);
            this.c_tpParseTree.Name = "c_tpParseTree";
            this.c_tpParseTree.Padding = new System.Windows.Forms.Padding(3);
            this.c_tpParseTree.Size = new System.Drawing.Size(806, 474);
            this.c_tpParseTree.TabIndex = 4;
            this.c_tpParseTree.Text = "Parse Tree";
            this.c_tpParseTree.UseVisualStyleBackColor = true;
            // 
            // c_tvParseTree
            // 
            this.c_tvParseTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_tvParseTree.Location = new System.Drawing.Point(-5, 0);
            this.c_tvParseTree.Name = "c_tvParseTree";
            this.c_tvParseTree.Size = new System.Drawing.Size(815, 478);
            this.c_tvParseTree.TabIndex = 0;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 525);
            this.Controls.Add(this.c_tcProject);
            this.Name = "LauncherForm";
            this.Text = "SDsLiCk Development Launcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LauncherForm_FormClosed);
            this.c_tcProject.ResumeLayout(false);
            this.c_tpFormAnalyser.ResumeLayout(false);
            this.c_tpFormAnalyser.PerformLayout();
            this.c_tpGUIBldr.ResumeLayout(false);
            this.c_tpSrcTreeEditor.ResumeLayout(false);
            this.c_splGUIBldr.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c_splGUIBldr)).EndInit();
            this.c_splGUIBldr.ResumeLayout(false);
            this.c_tpGDTree.ResumeLayout(false);
            this.c_tpParseTree.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl c_tcProject;
        private System.Windows.Forms.TabPage c_tpSrcTreeEditor;
        private System.Windows.Forms.SplitContainer c_splGUIBldr;
        private System.Windows.Forms.TabPage c_tpFormAnalyser;
        private System.Windows.Forms.TabPage c_tpGUIBldr;
        private System.Windows.Forms.Panel c_pnlCtrlHlder;
        private System.Windows.Forms.Label c_lblForms;
        private System.Windows.Forms.CheckedListBox c_clbForms;
        private System.Windows.Forms.Button c_butAnalyse;
        private System.Windows.Forms.Button c_butTEST;
        private System.Windows.Forms.TabPage c_tpGDTree;
        private System.Windows.Forms.TabPage c_tpParseTree;
        private System.Windows.Forms.TreeView c_tvParseTree;
        private System.Windows.Forms.TreeView c_tvGDTree;
        private System.Windows.Forms.ImageList c_ilIcons;
        private SourceTreeEditor sourceTreeEditor1;
    }
}

