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
            AppConfigCipherer configCipherer = new AppConfigCipherer();

            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AppConfigCiphererForm(configCipherer));
            }
            else if (args.Length == 3)
            {
                configCipherer.IsConsoleApplication = true;
                configCipherer.ExecutableFilePath = args[1];
                configCipherer.SectionName = args[2];

                switch (args[0])
                {
                    case "Encrypt":
                        configCipherer.EncryptConfigSection();
                        break;
                    case "Decrypt":
                        configCipherer.DecryptConfigSection();
                        break;
                    default:
                        Console.WriteLine($"Invalid command: {args[0]}");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Invalid command: command must be [Encrypt|Decrypt] <ExecutableFilePath> <SectionName>");
            }
        }
    }
}
