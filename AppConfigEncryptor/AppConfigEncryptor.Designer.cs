namespace AppConfigEncryptor
{
    partial class AppConfigEncryptor
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
            this.cmbEncryptDecrypt = new System.Windows.Forms.ComboBox();
            this.lblEncryptDecrypt = new System.Windows.Forms.Label();
            this.lblExecutableFile = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.btnEncryptDecrypt = new System.Windows.Forms.Button();
            this.openFileDialogExecutableFile = new System.Windows.Forms.OpenFileDialog();
            this.tbExecutableFile = new System.Windows.Forms.TextBox();
            this.btnOpenExecutableFile = new System.Windows.Forms.Button();
            this.cmbSectionName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbEncryptDecrypt
            // 
            this.cmbEncryptDecrypt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncryptDecrypt.FormattingEnabled = true;
            this.cmbEncryptDecrypt.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.cmbEncryptDecrypt.Location = new System.Drawing.Point(136, 34);
            this.cmbEncryptDecrypt.Name = "cmbEncryptDecrypt";
            this.cmbEncryptDecrypt.Size = new System.Drawing.Size(109, 21);
            this.cmbEncryptDecrypt.TabIndex = 0;
            this.cmbEncryptDecrypt.SelectedIndexChanged += new System.EventHandler(this.CmbEncryptDecrypt_SelectedIndexChanged);
            // 
            // lblEncryptDecrypt
            // 
            this.lblEncryptDecrypt.AutoSize = true;
            this.lblEncryptDecrypt.Location = new System.Drawing.Point(28, 38);
            this.lblEncryptDecrypt.Name = "lblEncryptDecrypt";
            this.lblEncryptDecrypt.Size = new System.Drawing.Size(85, 13);
            this.lblEncryptDecrypt.TabIndex = 1;
            this.lblEncryptDecrypt.Text = "Encrypt/Decrypt";
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
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(31, 162);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(292, 23);
            this.btnEncryptDecrypt.TabIndex = 6;
            this.btnEncryptDecrypt.UseVisualStyleBackColor = true;
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.BtnEncryptDecrypt_Click);
            // 
            // tbExecutableFile
            // 
            this.tbExecutableFile.Location = new System.Drawing.Point(136, 79);
            this.tbExecutableFile.Name = "tbExecutableFile";
            this.tbExecutableFile.ReadOnly = true;
            this.tbExecutableFile.Size = new System.Drawing.Size(159, 20);
            this.tbExecutableFile.TabIndex = 7;
            // 
            // btnOpenExecutableFile
            // 
            this.btnOpenExecutableFile.Location = new System.Drawing.Point(295, 78);
            this.btnOpenExecutableFile.Name = "btnOpenExecutableFile";
            this.btnOpenExecutableFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenExecutableFile.TabIndex = 8;
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
            this.cmbSectionName.TabIndex = 9;
            // 
            // AppConfigEncryptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 208);
            this.Controls.Add(this.cmbSectionName);
            this.Controls.Add(this.btnOpenExecutableFile);
            this.Controls.Add(this.tbExecutableFile);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.lblSectionName);
            this.Controls.Add(this.lblExecutableFile);
            this.Controls.Add(this.lblEncryptDecrypt);
            this.Controls.Add(this.cmbEncryptDecrypt);
            this.MaximumSize = new System.Drawing.Size(372, 247);
            this.MinimumSize = new System.Drawing.Size(372, 247);
            this.Name = "AppConfigEncryptor";
            this.Text = "AppConfigEncryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEncryptDecrypt;
        private System.Windows.Forms.Label lblEncryptDecrypt;
        private System.Windows.Forms.Label lblExecutableFile;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Button btnEncryptDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialogExecutableFile;
        private System.Windows.Forms.TextBox tbExecutableFile;
        private System.Windows.Forms.Button btnOpenExecutableFile;
        private System.Windows.Forms.ComboBox cmbSectionName;
    }
}

