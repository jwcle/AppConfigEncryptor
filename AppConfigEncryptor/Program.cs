using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace AppConfigCipherer
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
                switch (args[0])
                {
                    case "Encrypt":
                        string encryptMessage = configCipherer.EncryptConfigSection(args[1], args[2]);
                        Console.WriteLine(encryptMessage);
                        break;
                    case "Decrypt":
                        string decryptMessage = configCipherer.DecryptConfigSection(args[1], args[2]);
                        Console.WriteLine(decryptMessage);
                        break;
                    default:
                        Console.WriteLine($"Invalid command: '{args[0]}'");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Invalid command: command must be [Encrypt|Decrypt] <FilePath> <SectionName>");
            }
        }
    }
}
