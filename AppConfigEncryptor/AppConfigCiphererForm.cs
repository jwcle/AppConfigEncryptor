using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace AppConfigEncryptor
{
    public partial class AppConfigCiphererForm : Form
    {
        private readonly AppConfigCipherer _configCipherer;

        public AppConfigCiphererForm(AppConfigCipherer configCipherer)
        {
            InitializeComponent();

            _configCipherer = configCipherer;
            configCipherer.IsConsoleApplication = false;

            cmbEncryptDecrypt.SelectedIndex = 0;
            cmbSectionName.SelectedIndex = 0;
        }

        private void BtnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbExecutableFile.Text))
            {
                MessageBox.Show("Please select an executable file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _configCipherer.ExecutableFilePath = tbExecutableFile.Text;
            _configCipherer.SectionName = cmbSectionName.Text;

            if (cmbEncryptDecrypt.SelectedItem.Equals("Encrypt"))
            {
                _configCipherer.EncryptConfigSection();
            }
            else if (cmbEncryptDecrypt.SelectedItem.Equals("Decrypt"))
            {
                _configCipherer.DecryptConfigSection();
            }
        }

        private void CmbEncryptDecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEncryptDecrypt.Text = cmbEncryptDecrypt.Text;
        }

        private void BtnOpenExecutableFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = openFileDialogExecutableFile)
            {
                openFileDialog.InitialDirectory = @"C:\";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbExecutableFile.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
