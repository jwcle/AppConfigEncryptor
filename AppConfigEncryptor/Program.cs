using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace AppConfigEncryptor
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AppConfigEncryptor());
            }
            else
            {
                try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(args[1]);
                    ConfigurationSection section = config.GetSection(args[2]);

                    if (section == null)
                    {
                        Console.WriteLine($"Error: The selected section '{args[2]}' does not exist in the configuration file.");
                        return;
                    }

                    if (args[0] == "Encrypt")
                    {
                        if (!section.SectionInformation.IsProtected)
                        {
                            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                            config.Save();
                            Console.WriteLine("Encrypted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Section is already encrypted");
                        }
                    }
                    else if (args[0] == "Decrypt")
                    {
                        if (section.SectionInformation.IsProtected)
                        {
                            section.SectionInformation.UnprotectSection();
                            config.Save();
                            Console.WriteLine("Decrypted successfully");
                        }
                        else
                        {
                            Console.WriteLine("Section is already decrypted");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid command: {args[0]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
