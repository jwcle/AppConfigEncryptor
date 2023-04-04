using System;
using System.Configuration;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace AppConfigCipherer
{
    public class AppConfigCipherer
    {
        public string EncryptConfigSection(string executableFilePath, string sectionName)
        {
            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(executableFilePath);
                var section = GetConfigurationSection(configuration, sectionName);

                if (!section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    configuration.Save();
                    return "Encrypted successfully.";
                }
                else
                {
                    return "Error: Section is already encrypted.";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        public string DecryptConfigSection(string executableFilePath, string sectionName) 
        {
            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(executableFilePath);
                var section = GetConfigurationSection(configuration, sectionName);

                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                    configuration.Save();
                    return "Decrypted successfully.";
                }
                else
                {
                    return "Error: Section is already decrypted.";
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private ConfigurationSection GetConfigurationSection(Configuration configuration, string sectionName)
        {
            ConfigurationSection section = configuration.GetSection(sectionName);

            return section ?? throw new ArgumentException($"The selected section '{sectionName}' does not exist in the configuration file.");
        }
    }
}
