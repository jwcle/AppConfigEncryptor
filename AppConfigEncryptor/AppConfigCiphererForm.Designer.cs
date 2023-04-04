namespace AppConfigCipherer
{
    partial class AppConfigCiphererForm
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
            this.cmbCipher = new System.Windows.Forms.ComboBox();
            this.lblCipher = new System.Windows.Forms.Label();
            this.lblExecutableFile = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.btnCipher = new System.Windows.Forms.Button();
            this.openFileDialogExecutableFile = new System.Windows.Forms.OpenFileDialog();
            this.tbExecutableFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenExecutableFile = new System.Windows.Forms.Button();
            this.cmbSectionName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbCipher
            // 
            this.cmbCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCipher.FormattingEnabled = true;
            this.cmbCipher.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.cmbCipher.Location = new System.Drawing.Point(136, 34);
            this.cmbCipher.Name = "cmbCipher";
            this.cmbCipher.Size = new System.Drawing.Size(109, 21);
            this.cmbCipher.TabIndex = 0;
            this.cmbCipher.SelectedIndexChanged += new System.EventHandler(this.CmbEncryptDecrypt_SelectedIndexChanged);
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Location = new System.Drawing.Point(28, 38);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(85, 13);
            this.lblCipher.TabIndex = 1;
            this.lblCipher.Text = "Encrypt/Decrypt";
            // 
            // lblExecutableFile
            // 
            this.lblExecutableFile.AutoSize = true;
            this.lblExecutableFile.Location = new System.Drawing.Point(28, 82);
            this.lblExecutableFile.Name = "lblExecutableFile";
            this.lblExecutableFile.Size = new System.Drawing.Size(79, 13);
            this.lblExecutableFile.TabIndex = 2;
            this.lblExecutableFile.Text = "Executable File";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Location = new System.Drawing.Point(28, 121);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(74, 13);
            this.lblSectionName.TabIndex = 4;
            this.lblSectionName.Text = "Section Name";
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(31, 162);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(292, 23);
            this.btnCipher.TabIndex = 3;
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.BtnEncryptDecrypt_Click);
            // 
            // tbExecutableFilePath
            // 
            this.tbExecutableFilePath.Location = new System.Drawing.Point(136, 79);
            this.tbExecutableFilePath.Name = "tbExecutableFilePath";
            this.tbExecutableFilePath.ReadOnly = true;
            this.tbExecutableFilePath.Size = new System.Drawing.Size(159, 20);
            this.tbExecutableFilePath.TabIndex = 7;
            this.tbExecutableFilePath.TabStop = false;
            // 
            // btnOpenExecutableFile
            // 
            this.btnOpenExecutableFile.Location = new System.Drawing.Point(295, 78);
            this.btnOpenExecutableFile.Name = "btnOpenExecutableFile";
            this.btnOpenExecutableFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenExecutableFile.TabIndex = 1;
            this.btnOpenExecutableFile.Text = "...";
            this.btnOpenExecutableFile.UseVisualStyleBackColor = true;
            this.btnOpenExecutableFile.Click += new System.EventHandler(this.BtnOpenExecutableFile_Click);
            // 
            // cmbSectionName
            // 
            this.cmbSectionName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSectionName.FormattingEnabled = true;
            this.cmbSectionName.Items.AddRange(new object[] {
            "connectionStrings",
            "appSettings"});
            this.cmbSectionName.Location = new System.Drawing.Point(136, 118);
            this.cmbSectionName.Name = "cmbSectionName";
            this.cmbSectionName.Size = new System.Drawing.Size(187, 21);
            this.cmbSectionName.TabIndex = 2;
            // 
            // AppConfigCiphererForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 208);
            this.Controls.Add(this.cmbSectionName);
            this.Controls.Add(this.btnOpenExecutableFile);
            this.Controls.Add(this.tbExecutableFilePath);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.lblSectionName);
            this.Controls.Add(this.lblExecutableFile);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.cmbCipher);
            this.MaximumSize = new System.Drawing.Size(372, 247);
            this.MinimumSize = new System.Drawing.Size(372, 247);
            this.Name = "AppConfigCiphererForm";
            this.Text = "AppConfigCipherer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCipher;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.Label lblExecutableFile;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.OpenFileDialog openFileDialogExecutableFile;
        private System.Windows.Forms.TextBox tbExecutableFilePath;
        private System.Windows.Forms.Button btnOpenExecutableFile;
        private System.Windows.Forms.ComboBox cmbSectionName;
    }
}

