using System.Diagnostics;
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
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
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
