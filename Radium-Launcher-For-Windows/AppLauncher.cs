﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace Radium_Launcher
{
    public class AppLauncher {
        public const string PYTHON_PATH = @"python.exe"; 

        private string path;
        private string url;
        private string appTitle; 
        public AppLauncher(string path, string appTitle) {
            this.path = path;
            this.appTitle = appTitle;
        }

        public AppLauncher(string url) {
            this.url = url;
        }

        /// <summary>
        /// Cette méthode permet de lancer une explication. 
        /// </summary>
        public void LaunchApp() {
            try {
                var process = Process.Start(this.path);
                process.WaitForExit();
            }
            catch {
                MessageBox.Show($"Radium Launcher n'a pas pu executer le fichier {this.appTitle}", "Une erreur inattendu c'est produite");
            }
        }

        /// <summary>
        /// Cette méthode permet de lancer des app (.exe) qui ont besoin d'une certaine permission système. 
        /// </summary>
        /// <exception cref="UnauthorizedAccessException"></exception>
        public void LaunchWithElevatedPrivileged() {
            SystemManagement sys = new SystemManagement();
            if (sys.isItAElevatedProcess())
            {
                try
                {
                    var process = Process.Start(this.path);
                    process.WaitForExit();
                }
                catch
                {
                    MessageBox.Show($"Radium Launcher n'a pu executer le fichier " +
                        $"{this.appTitle}. Avez-vous ouvert l'applis en mode administrateur?",
                        $"Une erreur c'est produite lors de l'éxecution de {this.appTitle}");
                }
            }

            else
            {
                 MessageBox.Show("L'application doit redémarrer avec des privilèges élevés pour effectuer cette action. Veuillez réessayer.");
            }
        }

        /// <summary>
        /// Cette méthode permet d'ouvrir une page web vers le navigateur par défaut.
        /// <example>  <br></br> Exemple: (constructeur omis pour simplifier) <code> sys.OpenBrowser("<see cref="https://www.microsoft.com"/>") </code> </example> 
        /// </summary>
        public void OpenBrowser() {
            var process = Process.Start("explorer", this.url);
            process.WaitForExit(); 
        }

    }
}
