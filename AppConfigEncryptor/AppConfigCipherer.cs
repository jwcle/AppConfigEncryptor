using System;
using System.Configuration;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using System.IO;

namespace AppConfigCipherer
{
    public class AppConfigCipherer
    {
        public string EncryptConfigSection(string filePath, string sectionName)
        {
            if (!File.Exists(filePath + ".config"))
            {
                return $"{filePath}.config does not exist in the file path.";
            }

            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(filePath);
                var section = configuration.GetSection(sectionName);

                if (section == null)
                {
                    return $"The selected section '{sectionName}' does not exist in the configuration file.";
                }

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

        public string DecryptConfigSection(string filePath, string sectionName) 
        {
            if (!File.Exists(filePath + ".config"))
            {
                return $"{filePath}.config does not exist in the file directory.";
            }

            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(filePath);
                var section = configuration.GetSection(sectionName);

                if (section == null)
                {
                    return $"The selected section '{sectionName}' does not exist in the configuration file.";
                }

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
    }
}
