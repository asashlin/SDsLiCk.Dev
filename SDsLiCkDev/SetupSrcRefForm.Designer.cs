namespace SDsLiCk.Dev
{
    partial class SetupSrcRefForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupSrcRefForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.c_txtlWrkngDir = new System.Windows.Forms.TextBox();
            this.c_butBrowseWD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_cmbSolutions = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c_lblSolution = new System.Windows.Forms.Label();
            this.c_lblProject = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.c_dlgfolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.c_lvProjects = new System.Windows.Forms.ListView();
            this.c_hdrPrjName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_hdrSolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_hdrPrjPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.c_splSrcSel = new System.Windows.Forms.SplitContainer();
            this.c_lvSourceFiles = new System.Windows.Forms.ListView();
            this.c_hdrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_hdrProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_hdrPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c_splSrcSel)).BeginInit();
            this.c_splSrcSel.Panel1.SuspendLayout();
            this.c_splSrcSel.Panel2.SuspendLayout();
            this.c_splSrcSel.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_txtlWrkngDir
            // 
            this.c_txtlWrkngDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_txtlWrkngDir.Location = new System.Drawing.Point(13, 26);
            this.c_txtlWrkngDir.Name = "c_txtlWrkngDir";
            this.c_txtlWrkngDir.ReadOnly = true;
            this.c_txtlWrkngDir.Size = new System.Drawing.Size(375, 20);
            this.c_txtlWrkngDir.TabIndex = 0;
            // 
            // c_butBrowseWD
            // 
            this.c_butBrowseWD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c_butBrowseWD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c_butBrowseWD.BackgroundImage")));
            this.c_butBrowseWD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.c_butBrowseWD.Location = new System.Drawing.Point(394, 26);
            this.c_butBrowseWD.Name = "c_butBrowseWD";
            this.c_butBrowseWD.Size = new System.Drawing.Size(32, 20);
            this.c_butBrowseWD.TabIndex = 2;
            this.c_butBrowseWD.UseVisualStyleBackColor = true;
            this.c_butBrowseWD.Click += new System.EventHandler(this.c_butBrowseWD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Working Directory";
            // 
            // c_cmbSolutions
            // 
            this.c_cmbSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_cmbSolutions.FormattingEnabled = true;
            this.c_cmbSolutions.Location = new System.Drawing.Point(13, 67);
            this.c_cmbSolutions.Name = "c_cmbSolutions";
            this.c_cmbSolutions.Size = new System.Drawing.Size(375, 21);
            this.c_cmbSolutions.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(394, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 20);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // c_lblSolution
            // 
            this.c_lblSolution.AutoSize = true;
            this.c_lblSolution.Location = new System.Drawing.Point(10, 51);
            this.c_lblSolution.Name = "c_lblSolution";
            this.c_lblSolution.Size = new System.Drawing.Size(45, 13);
            this.c_lblSolution.TabIndex = 6;
            this.c_lblSolution.Text = "Solution";
            // 
            // c_lblProject
            // 
            this.c_lblProject.AutoSize = true;
            this.c_lblProject.Location = new System.Drawing.Point(10, 95);
            this.c_lblProject.Name = "c_lblProject";
            this.c_lblProject.Size = new System.Drawing.Size(45, 13);
            this.c_lblProject.TabIndex = 9;
            this.c_lblProject.Text = "Projects";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(394, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 20);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(394, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 20);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // c_lvProjects
            // 
            this.c_lvProjects.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.c_lvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_lvProjects.CheckBoxes = true;
            this.c_lvProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_hdrPrjName,
            this.c_hdrSolution,
            this.c_hdrPrjPath});
            this.c_lvProjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.c_lvProjects.HideSelection = false;
            this.c_lvProjects.HoverSelection = true;
            this.c_lvProjects.Location = new System.Drawing.Point(0, 0);
            this.c_lvProjects.Name = "c_lvProjects";
            this.c_lvProjects.Size = new System.Drawing.Size(375, 106);
            this.c_lvProjects.TabIndex = 12;
            this.c_lvProjects.UseCompatibleStateImageBehavior = false;
            this.c_lvProjects.View = System.Windows.Forms.View.Details;
            // 
            // c_hdrPrjName
            // 
            this.c_hdrPrjName.Text = "Name";
            this.c_hdrPrjName.Width = 80;
            // 
            // c_hdrSolution
            // 
            this.c_hdrSolution.Text = "Solution";
            this.c_hdrSolution.Width = 94;
            // 
            // c_hdrPrjPath
            // 
            this.c_hdrPrjPath.Text = "Path";
            this.c_hdrPrjPath.Width = 241;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Source Files";
            // 
            // c_splSrcSel
            // 
            this.c_splSrcSel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_splSrcSel.Location = new System.Drawing.Point(13, 111);
            this.c_splSrcSel.Name = "c_splSrcSel";
            this.c_splSrcSel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // c_splSrcSel.Panel1
            // 
            this.c_splSrcSel.Panel1.Controls.Add(this.c_lvProjects);
            // 
            // c_splSrcSel.Panel2
            // 
            this.c_splSrcSel.Panel2.Controls.Add(this.c_lvSourceFiles);
            this.c_splSrcSel.Panel2.Controls.Add(this.label2);
            this.c_splSrcSel.Size = new System.Drawing.Size(375, 349);
            this.c_splSrcSel.SplitterDistance = 109;
            this.c_splSrcSel.TabIndex = 14;
            // 
            // c_lvSourceFiles
            // 
            this.c_lvSourceFiles.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.c_lvSourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_lvSourceFiles.CheckBoxes = true;
            this.c_lvSourceFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_hdrName,
            this.c_hdrProject,
            this.c_hdrPath});
            this.c_lvSourceFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.c_lvSourceFiles.HideSelection = false;
            this.c_lvSourceFiles.HoverSelection = true;
            this.c_lvSourceFiles.Location = new System.Drawing.Point(0, 17);
            this.c_lvSourceFiles.Name = "c_lvSourceFiles";
            this.c_lvSourceFiles.Size = new System.Drawing.Size(375, 219);
            this.c_lvSourceFiles.TabIndex = 14;
            this.c_lvSourceFiles.UseCompatibleStateImageBehavior = false;
            this.c_lvSourceFiles.View = System.Windows.Forms.View.Details;
            // 
            // c_hdrName
            // 
            this.c_hdrName.Text = "Name";
            this.c_hdrName.Width = 80;
            // 
            // c_hdrProject
            // 
            this.c_hdrProject.Text = "Project";
            this.c_hdrProject.Width = 92;
            // 
            // c_hdrPath
            // 
            this.c_hdrPath.Text = "Path";
            this.c_hdrPath.Width = 242;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(351, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(270, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(167, 477);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(394, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "S";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(394, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(394, 412);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "C";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Location = new System.Drawing.Point(394, 383);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(32, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "S";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // SetupSrcRefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 512);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.c_splSrcSel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.c_lblProject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.c_lblSolution);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_cmbSolutions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_butBrowseWD);
            this.Controls.Add(this.c_txtlWrkngDir);
            this.Name = "SetupSrcRefForm";
            this.Text = "SetupSrcRefForm";
            this.c_splSrcSel.Panel1.ResumeLayout(false);
            this.c_splSrcSel.Panel2.ResumeLayout(false);
            this.c_splSrcSel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_splSrcSel)).EndInit();
            this.c_splSrcSel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox c_txtlWrkngDir;
        private System.Windows.Forms.Button c_butBrowseWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_cmbSolutions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label c_lblSolution;
        private System.Windows.Forms.Label c_lblProject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog c_dlgfolderBrowser;
        private System.Windows.Forms.ListView c_lvProjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer c_splSrcSel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader c_hdrPrjName;
        private System.Windows.Forms.ColumnHeader c_hdrSolution;
        private System.Windows.Forms.ColumnHeader c_hdrPrjPath;
        private System.Windows.Forms.ListView c_lvSourceFiles;
        private System.Windows.Forms.ColumnHeader c_hdrName;
        private System.Windows.Forms.ColumnHeader c_hdrProject;
        private System.Windows.Forms.ColumnHeader c_hdrPath;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}