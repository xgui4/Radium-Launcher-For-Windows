using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radium_Launcher
{
    class SystemManagement
    {
        private string windowsVersion;
        private string dotnetVersion;
        private string defaultBrowser;
        private bool is64Bit;

        public SystemManagement()
        {
            windowsVersion = Environment.OSVersion.ToString();
            dotnetVersion = Environment.Version.ToString();
            defaultBrowser = this.GetDefaultBrowser();
        }

        public bool isItAElevatedProcess()
        {
            bool isElevatedProcess = Environment.IsPrivilegedProcess; 
            return isElevatedProcess;
        }


        /// <summary>
        /// Cette méthode permet d'ouvrir une page web vers le navigateur par défaut.
        /// <param name="url"></param>
        /// <example>  <br></br> Exemple: (constructeur omis pour simplifier) <code> sys.OpenBrowser("<see cref="https://www.microsoft.com"/>") </code> </example> 
        /// </summary>
        public void OpenBrowser(string url)
        {
            Process.Start("explorer", url);
        }

        /// <summary>
        /// Cette méthode permet d'obtenur le naviagateur par défaut. Àvec l'aide du régistre Windows.
        /// </summary>
        /// <returns> Retourne le navigateur par défaut. </returns>
        public string GetDefaultBrowser()
        {
            string defaultBrowser = "msedge.exe";

            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        defaultBrowser = progIdValue.ToString();
                    }
                }
            }

            return defaultBrowser;
        }
    }
}
