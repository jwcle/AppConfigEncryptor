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

            if (cmbEncryptDecrypt.SelectedItem.Equals("Encrypt"))
            {
                MessageBox.Show(_configCipherer.EncryptConfigSection(tbExecutableFile.Text, cmbSectionName.Text));
            }
            else if (cmbEncryptDecrypt.SelectedItem.Equals("Decrypt"))
            {
                MessageBox.Show(_configCipherer.DecryptConfigSection(tbExecutableFile.Text, cmbSectionName.Text));
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
