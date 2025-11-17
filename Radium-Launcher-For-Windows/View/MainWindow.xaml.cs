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
        private readonly string notAvaialble = "";
        private readonly Runner appRunner = new Runner();

        /// <summary>
        /// La fenêtre principale de l'app
        /// </summary>
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
            appRunner.SetPath("Assets\\mc.lnk");
            appRunner.SetName("Minecraft Launcher");
            appRunner.OpenBrowser(); // temporaire
            appRunner.Clear(); 
        }
        private void LaunchModrinth_Selected(object sender, MouseButtonEventArgs e)
        {
            appRunner.SetPath("C:\\Program Files\\Modrinth App\\Modrinth App.exe");
            appRunner.SetName("Modrinth App"); 
            appRunner.LaunchApp(); 
            appRunner.Clear();
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