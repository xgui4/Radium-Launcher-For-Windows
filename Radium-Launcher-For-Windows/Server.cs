using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace Radium_Launcher
{
    /// <summary>
    /// Cette classe est un implémentation prototype de base donnée (pour le moment local) 
    /// qui fonctionne en PostgreSQL et Python
    /// </summary>
    public class Server
    {
        public const string CONNECTION_STRING = @"C:\\programmation\\Radium-Launcher\\Radium-Launcher\\server\\database\\connect.py"; 
        public Server() 
        {
        }

        public string Connect()
        {
            string output = "N/A";
            var launcher = new AppLauncher(CONNECTION_STRING, ""); 
            output = launcher.LaunchPythonOutput();
            return output;
        }
    }
}
