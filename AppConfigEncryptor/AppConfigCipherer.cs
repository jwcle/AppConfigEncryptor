using System;
using System.Configuration;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace AppConfigEncryptor
{
    public class AppConfigCipherer
    {
        public bool IsConsoleApplication { get; set; }
        public string ExecutableFilePath { get; set; }
        public string SectionName { get; set; }

        public void EncryptConfigSection()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ExecutableFilePath);
            var section = GetConfigurationSection(configuration);

            try
            {
                if (!section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    configuration.Save();
                    ShowMessage("Encrypted successfully.");
                }
                else
                {
                    ShowMessage("Error: Section is already encrypted.");
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error: {ex.Message}");
            }
        }

        public void DecryptConfigSection() 
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(ExecutableFilePath);
            var section = GetConfigurationSection(configuration);

            try
            {
                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                    configuration.Save();
                    ShowMessage("Decrypted successfully.");
                }
                else
                {
                    ShowMessage("Error: Section is already decrypted.");
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Error: {ex.Message}");
            }
        }

        private ConfigurationSection GetConfigurationSection(Configuration configuration)
        {
            ConfigurationSection section = configuration.GetSection(SectionName);

            return section ?? throw new ArgumentException($"The selected section '{SectionName}' does not exist in the configuration file.");
        }

        public void ShowMessage(string message)
        {
            if (IsConsoleApplication)
            {
                Console.WriteLine(message);
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
