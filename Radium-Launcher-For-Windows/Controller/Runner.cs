using System.Diagnostics;
using System.Windows; 

namespace Radium_Launcher_For_Windows.Controller
{
    /// <summary>
    /// Permet de lancer un app ou un lien URL
    /// </summary>
    public class Runner
    {
        /// <summary>
        /// Le chemin vers l'exécutable ou l'URL
        /// </summary>
        public string Path { private get; set; } = ""; 

        /// <summary>
        /// Le nom du programme (valeur par défaut = "")
        /// </summary>
        public string Name { private get; set; } = ""; 

        /// <summary>
        /// Permet de crée un lanceur. 
        /// </summary>
        public Runner()
        {
        }

        /// <summary>
        /// Permet de paramètré 
        /// </summary>
        /// <param Name="path"></param>
        public void SetPath(string path)
        {
            this.Path = path;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param Name="name"></param>
        public void SetName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Cette méthode permet de lancer une explication. 
        /// </summary>
        public void LaunchApp()
        {
            try
            {
                var process = Process.Start(Path);
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
                    var process = Process.Start(Path);
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
            var process = Process.Start("explorer", Path);
            process.WaitForExit();
        }
        
        /// <summary>
        /// Remettre la path et le name dans leur valeur par défaut.
        /// </summary>
        public void Clear()
        {
            Path = "";
            Name = ""; 
        }

    }
}
