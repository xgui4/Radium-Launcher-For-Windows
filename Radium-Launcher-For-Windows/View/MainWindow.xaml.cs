using Radium_Launcher_For_Windows;
using Radium_Launcher_For_Windows.Controller;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
            string comingSoon = (string)this.FindResource("Coming Soon");
        }

        private void LaunchMinecraftLauncherMS_Selected(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var processInfo = new ProcessStartInfo("../Scripts/launch.bat");

                var process = Process.Start(processInfo);

                process.Start();

                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Radium Runner n'a pas pu executer le fichier launch.bat", "Une erreur inentendu c'est produite");
            }

        }

        private void LaunchBedrockLauncher_Selected(object sender, MouseButtonEventArgs e)
        {
            var launcher = new Runner("C:\\Program Files\\BedrockLauncher\\app\\BedrockLauncher.exe\"", "Bedrock Runner");
            launcher.LaunchWithElevatedPrivileged();
        }

        private void LaunchAmethyst_Selected(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var process = Process.Start("C:\\Program Files\\Amethyst Runner\\Amethyst Runner.exe");
                process.WaitForExit(); 
            }
            catch
            {
                MessageBox.Show("Radium Runner n'a pas pu executer le fichier Amethyst Runner.exe", "Une erreur inentendu c'est produite");
            }
        }

        private void LaunchModrinth_Selected(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var process = Process.Start("C:\\Program Files\\Modrinth App\\Modrinth App.exe");
                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Radium Runner n'a pas pu executer le fichier Modrinth App.exe", "Une erreur inentendu c'est produite");
            }
        }

        private void OpenSetting_Selected(object sender, MouseButtonEventArgs e)
        {
            Apps settingWindow = new Apps();
            settingWindow.Show();
        }

        private void Connection_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("La fonction de connection va subir un re-work complet. La fonction a donc été enlever pour l'instant");
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