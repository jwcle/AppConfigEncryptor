using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace AppConfigCipherer
{
    public partial class AppConfigCiphererForm : Form
    {
        private readonly AppConfigCipherer _configCipherer;

        public AppConfigCiphererForm(AppConfigCipherer configCipherer)
        {
            InitializeComponent();

            _configCipherer = configCipherer;

            cmbCipher.SelectedIndex = 0;
            cmbSectionName.SelectedIndex = 0;
        }

        private void BtnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbExecutableFilePath.Text))
            {
                MessageBox.Show("Please select an executable file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCipher.SelectedItem.Equals("Encrypt"))
            {
                MessageBox.Show(_configCipherer.EncryptConfigSection(tbExecutableFilePath.Text, cmbSectionName.Text));
            }
            else if (cmbCipher.SelectedItem.Equals("Decrypt"))
            {
                MessageBox.Show(_configCipherer.DecryptConfigSection(tbExecutableFilePath.Text, cmbSectionName.Text));
            }
        }

        private void CmbEncryptDecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCipher.Text = cmbCipher.Text;
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
                    tbExecutableFilePath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
