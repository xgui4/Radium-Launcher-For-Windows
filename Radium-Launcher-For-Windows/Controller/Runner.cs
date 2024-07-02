using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using System.Windows; 

namespace Radium_Launcher_For_Windows.Controller
{
    public class Runner
    {
        private readonly string path;
        private readonly string name;
        public Runner(string path, string name = "")
        {
            this.path = path;
            this.name = name;
        }

        /// <summary>
        /// Cette méthode permet de lancer une explication. 
        /// </summary>
        public void LaunchApp()
        {
            try
            {
                var process = Process.Start(path);
                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show($"Radium Runner n'a pas pu executer le fichier {name}", "Une erreur inattendu c'est produite");
            }
        }

        /// <summary>
        /// Cette méthode permet de lancer des app (.exe) qui ont besoin d'une certaine permission système. 
        /// </summary>
        /// <exception cref="UnauthorizedAccessException"></exception>
        public void LaunchWithElevatedPrivileged()
        {
            if (IsItAElevatedProcess())
            {
                try
                {
                    var process = Process.Start(path);
                    process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show($"Radium Runner n'a pu executer le fichier " +
                        $"{name}. Avez-vous ouvert l'applis en mode administrateur?",
                        $"Une erreur c'est produite lors de l'éxecution de {name}");
                }
            }

            else
            {
                MessageBox.Show("L'application doit redémarrer avec des privilèges élevés pour effectuer cette action. Veuillez réessayer.");
            }
        }
        private static bool IsItAElevatedProcess()
        {
            bool isElevatedProcess = Environment.IsPrivilegedProcess;
            return isElevatedProcess;
        }

        /// <summary>
        /// Cette méthode permet d'ouvrir une page web vers le navigateur par défaut.
        /// </summary>
        public void OpenBrowser()
        {
            var process = Process.Start("explorer", path);
            process.WaitForExit();
        }



    }
}
