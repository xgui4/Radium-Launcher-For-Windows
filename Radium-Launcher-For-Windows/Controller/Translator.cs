using System.Windows;

namespace Radium_Launcher_For_Windows.Controller
{
    public class Translator
    {
        private readonly Window Window;

        public Translator(Window window) 
        { 
            Window = window;
        }

        public string TranslateToString(string text)
        {
            return (string)Window.FindResource(text);
        }

        public bool TranslateToBool(string text)
        {
            return (bool)Window.FindResource(text);
        }


    }
}
