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
            if (string.IsNullOrWhiteSpace(tbFilePath.Text))
            {
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCipher.SelectedItem.Equals("Encrypt"))
            {
                MessageBox.Show(_configCipherer.EncryptConfigSection(tbFilePath.Text, cmbSectionName.Text));
            }
            else if (cmbCipher.SelectedItem.Equals("Decrypt"))
            {
                MessageBox.Show(_configCipherer.DecryptConfigSection(tbFilePath.Text, cmbSectionName.Text));
            }
        }

        private void CmbEncryptDecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCipher.Text = cmbCipher.Text;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogFile.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialogFile.FileName;
            }
        }
    }
}
