namespace GlueCompiler.Controls
{
    partial class BuildUi
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
            this.cmbBuildType = new System.Windows.Forms.ComboBox();
            this.btnCompile = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListView();
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkShowErrors = new System.Windows.Forms.CheckBox();
            this.chkShowWarnings = new System.Windows.Forms.CheckBox();
            this.lblCompileMessage = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBuildType
            // 
            this.cmbBuildType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuildType.FormattingEnabled = true;
            this.cmbBuildType.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.cmbBuildType.Location = new System.Drawing.Point(3, 3);
            this.cmbBuildType.Name = "cmbBuildType";
            this.cmbBuildType.Size = new System.Drawing.Size(121, 21);
            this.cmbBuildType.TabIndex = 1;
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(130, 3);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(75, 23);
            this.btnCompile.TabIndex = 3;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmType,
            this.clmMessage,
            this.clmLineNumber,
            this.clmFile,
            this.clmProject});
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMessages.Location = new System.Drawing.Point(3, 32);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(511, 372);
            this.lstMessages.TabIndex = 4;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            this.lstMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMessages_KeyDown);
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            // 
            // clmMessage
            // 
            this.clmMessage.Text = "Message";
            this.clmMessage.Width = 206;
            // 
            // clmLineNumber
            // 
            this.clmLineNumber.Text = "Line Number";
            this.clmLineNumber.Width = 106;
            // 
            // clmFile
            // 
            this.clmFile.Text = "File";
            // 
            // clmProject
            // 
            this.clmProject.Text = "Project";
            // 
            // chkShowErrors
            // 
            this.chkShowErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowErrors.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowErrors.AutoSize = true;
            this.chkShowErrors.Location = new System.Drawing.Point(347, 3);
            this.chkShowErrors.Name = "chkShowErrors";
            this.chkShowErrors.Size = new System.Drawing.Size(68, 23);
            this.chkShowErrors.TabIndex = 5;
            this.chkShowErrors.Text = "XXX Errors";
            this.chkShowErrors.UseVisualStyleBackColor = true;
            this.chkShowErrors.CheckedChanged += new System.EventHandler(this.ToggleButtonsCheckedChange);
            // 
            // chkShowWarnings
            // 
            this.chkShowWarnings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowWarnings.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowWarnings.AutoSize = true;
            this.chkShowWarnings.Location = new System.Drawing.Point(421, 3);
            this.chkShowWarnings.Name = "chkShowWarnings";
            this.chkShowWarnings.Size = new System.Drawing.Size(86, 23);
            this.chkShowWarnings.TabIndex = 6;
            this.chkShowWarnings.Text = "XXX Warnings";
            this.chkShowWarnings.UseVisualStyleBackColor = true;
            this.chkShowWarnings.CheckedChanged += new System.EventHandler(this.ToggleButtonsCheckedChange);
            // 
            // lblCompileMessage
            // 
            this.lblCompileMessage.AutoSize = true;
            this.lblCompileMessage.Location = new System.Drawing.Point(292, 11);
            this.lblCompileMessage.Name = "lblCompileMessage";
            this.lblCompileMessage.Size = new System.Drawing.Size(123, 13);
            this.lblCompileMessage.TabIndex = 7;
            this.lblCompileMessage.Text = "Compiling, please wait....";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(211, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // BuildUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblCompileMessage);
            this.Controls.Add(this.chkShowWarnings);
            this.Controls.Add(this.chkShowErrors);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.cmbBuildType);
            this.Name = "BuildUi";
            this.Size = new System.Drawing.Size(517, 407);
            this.Load += new System.EventHandler(this.BuildUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBuildType;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.ColumnHeader clmMessage;
        private System.Windows.Forms.ColumnHeader clmProject;
        private System.Windows.Forms.ColumnHeader clmFile;
        private System.Windows.Forms.ColumnHeader clmLineNumber;
        private System.Windows.Forms.CheckBox chkShowErrors;
        private System.Windows.Forms.CheckBox chkShowWarnings;
        private System.Windows.Forms.Label lblCompileMessage;
        private System.Windows.Forms.Button btnRun;
    }
}
