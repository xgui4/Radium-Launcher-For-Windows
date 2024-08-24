using Radium_Launcher_For_Windows;
using Radium_Launcher_For_Windows.Controller;
using System.Windows;
using System.Windows.Input;
using MessageBox = System.Windows.MessageBox;

namespace Radium_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string credential = "";
        string notAvaialble = "";
        public MainWindow()
        {
            InitializeComponent();
            Translator translator = new Translator(this);
            string info = translator.TranslateToString("StartUp Message");
            bool isDevMode = translator.TranslateToBool("Is Dev Version");
            string titleName = translator.TranslateToString("Name");
            string version = translator.TranslateToString("Version");
            string releaseType = translator.TranslateToString("Release Type");
            notAvaialble = translator.TranslateToString("Login Not Availaible Message");

            this.Title = $"{titleName} {version} {releaseType}";

            if (isDevMode)
            {                
                MessageBox.Show(""); // en enlevant cette messageBox le fenêtre principale remplace la messagebox et la ferme
                this.Hide();
                MessageBox.Show(info);
                this.Show();
            }
        }

        private void LaunchMinecraftLauncherMS_Selected(object sender, MouseButtonEventArgs e)
        {
            var runner = new Runner("..\\Scripts\\launch.bat\\");
            runner.LaunchApp();
        }

        private void LaunchBedrockLauncher_Selected(object sender, MouseButtonEventArgs e)
        {
            var launcher = new Runner("C:\\Program Files\\BedrockLauncher\\app\\BedrockLauncher.exe\"", "Bedrock Runner");
            launcher.LaunchWithElevatedPrivileged();
        }

        private void LaunchAmethyst_Selected(object sender, MouseButtonEventArgs e)
        {
            var runner = new Runner("C:\\Program Files\\Amethyst Launcher\\Amethyst Launcher.exe");
            runner.LaunchApp();
        }

        private void LaunchModrinth_Selected(object sender, MouseButtonEventArgs e)
        {
            var runner = new Runner("C:\\Program Files\\Modrinth App\\Modrinth App.exe");
            runner.LaunchApp(); 
        }

        private void OpenSetting_Selected(object sender, MouseButtonEventArgs e)
        {
            NavigatorController.NavigateToPage2(this);
        }

        private void Connection_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(notAvaialble); 
        }

        private void AboutBox_Selected(object sender, RoutedEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void Launch_launcher_Selected(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("À venir");
        }
    }
}       