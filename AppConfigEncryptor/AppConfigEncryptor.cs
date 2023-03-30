using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (tbExecutableFile.Text == "")
            {
                MessageBox.Show("Please select the executable file.");
            }
            else
            {
                SetConfigSectionEncryption();
            }
        }

        private void SetConfigSectionEncryption()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(tbExecutableFile.Text);
                ConfigurationSection section = config.GetSection(cmbSectionName.Text);

                if (cmbEncryptDecrypt.SelectedItem.Equals("Encrypt") && !section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    config.Save();
                    MessageBox.Show($"Encrypted successfully");
                }
                else if (cmbEncryptDecrypt.SelectedItem.Equals("Decrypt") && section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                    config.Save();
                    MessageBox.Show($"Decrypted successfully");
                }
                else
                {
                    MessageBox.Show($"Please check if '{cmbSectionName.Text}' of '{tbExecutableFile.Text}.config' is ready to be '{cmbEncryptDecrypt.SelectedItem}ed'.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
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
