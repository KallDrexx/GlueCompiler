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
            this.SuspendLayout();
            // 
            // cmbBuildType
            // 
            this.cmbBuildType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuildType.FormattingEnabled = true;
            this.cmbBuildType.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.cmbBuildType.Location = new System.Drawing.Point(3, 15);
            this.cmbBuildType.Name = "cmbBuildType";
            this.cmbBuildType.Size = new System.Drawing.Size(121, 21);
            this.cmbBuildType.TabIndex = 1;
            // 
            // btnCompile
            // 
            this.btnCompile.Location = new System.Drawing.Point(130, 15);
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
            this.lstMessages.Location = new System.Drawing.Point(3, 61);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(511, 343);
            this.lstMessages.TabIndex = 4;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            this.lstMessages.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstMessages_ColumnClick);
            this.lstMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMessages_KeyDown);
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            // 
            // clmMessage
            // 
            this.clmMessage.Text = "Message";
            // 
            // clmLineNumber
            // 
            this.clmLineNumber.Text = "Line Number";
            // 
            // clmFile
            // 
            this.clmFile.Text = "File";
            // 
            // clmProject
            // 
            this.clmProject.Text = "Project";
            // 
            // BuildUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.cmbBuildType);
            this.Name = "BuildUi";
            this.Size = new System.Drawing.Size(517, 407);
            this.Load += new System.EventHandler(this.BuildUi_Load);
            this.ResumeLayout(false);

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
    }
}
