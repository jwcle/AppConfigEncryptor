using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace AppConfigEncryptor
{
    public partial class AppConfigEncryptor : Form
    {
        public AppConfigEncryptor()
        {
            InitializeComponent();
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

            EncryptOrDecryptConfigSection();
        }

        private void EncryptOrDecryptConfigSection()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(tbExecutableFile.Text);
                ConfigurationSection section = config.GetSection(cmbSectionName.Text);

                if (section == null)
                {
                    MessageBox.Show($"The selected section '{cmbSectionName.Text}' does not exist in the configuration file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cmbEncryptDecrypt.SelectedItem.Equals("Encrypt") && !section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    config.Save();
                    MessageBox.Show("Encrypted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbEncryptDecrypt.SelectedItem.Equals("Decrypt") && section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                    config.Save();
                    MessageBox.Show("Decrypted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Please check if '{cmbSectionName.Text}' of '{tbExecutableFile.Text}.config' is ready to be '{cmbEncryptDecrypt.SelectedItem}ed'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
