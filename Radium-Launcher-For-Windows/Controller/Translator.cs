using System.Windows;

namespace Radium_Launcher_For_Windows.Controller
{
    /// <summary>
    /// C'est la classe qui permet de traduire un string avec des ressources xaml 
    /// </summary>
    public class Translator
    {
        private readonly Window Window;

        /// <summary>
        /// Permet de crée le traducteur de la fenêtre (objet Window)
        /// </summary>
        /// <param Name="window"></param>
        public Translator(Window window) 
        { 
            Window = window;
        }

        /// <summary>
        /// Permet de traduire une string en a une langue avec une ressource xaml
        /// </summary>
        /// <param Name="text"></param>
        /// <returns></returns>
        public string TranslateToString(string text)
        {
            return (string)Window.FindResource(text);
        }

        /// <summary>
        /// Permet de traduire une string en un boolean (va être modifié bientôt)
        /// </summary>
        /// <param Name="text"></param>
        /// <returns></returns>
        public bool TranslateToBool(string text)
        {
            return (bool)Window.FindResource(text);
        }

    }
}
