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
            SystemManagement sys;
        }

        private void mcLauncherSelected(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var processInfo = new ProcessStartInfo("Scripts/launch.bat");

                var process = Process.Start(processInfo);

                process.Start();

                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Radium Launcher n'a pas pu executer le fichier launch.bat", "Une erreur inentendu c'est produite");
            }

        }

        private void mcBedrockSelected(object sender, MouseButtonEventArgs e)
        {
            var launcher = new AppLauncher("C:\\Program Files\\BedrockLauncher\\app\\BedrockLauncher.exe\"", "Bedrock Launcher");
            launcher.LaunchWithElevatedPrivileged();
        }

        private void launchAmethyst(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var process = Process.Start("C:\\Program Files\\Amethyst Launcher\\Amethyst Launcher.exe");
                process.WaitForExit(); 
            }
            catch
            {
                MessageBox.Show("Radium Launcher n'a pas pu executer le fichier Amethyst Launcher.exe", "Une erreur inentendu c'est produite");
            }
        }

        private void launchModrinth(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var process = Process.Start("C:\\Program Files\\Modrinth App\\Modrinth App.exe");
                process.WaitForExit();
            }
            catch
            {
                MessageBox.Show("Radium Launcher n'a pas pu executer le fichier Modrinth App.exe", "Une erreur inentendu c'est produite");
            }
        }

        private void openSetting(object sender, MouseButtonEventArgs e)
        {
            Apps settingWindow = new Apps();
            settingWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("La fonction de connection va subir un re-work complet. La fonction a donc été enlever pour l'instant");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
    }
}       