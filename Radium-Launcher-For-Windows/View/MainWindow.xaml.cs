using Radium_Launcher_For_Windows;
using Radium_Launcher_For_Windows.Controller;
using Radium_Launcher_For_Windows.Server.Database;
using Radium_Launcher_For_Windows.View;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Xps.Packaging;
using Windows.Devices.Sensors;
using MessageBox = System.Windows.MessageBox;

namespace Radium_Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string credential = ""; 
        public MainWindow()
        {
            InitializeComponent();
            string info = (string)this.FindResource("StartUp Message");
            bool isDevMode = (bool)this.FindResource("Is Dev Version");
            string titleName = (string)this.FindResource("Name");
            string version = (string)this.FindResource("Version");
            string releaseType = (string)this.FindResource("Release Type");

            this.Title = titleName + " " +  version  + " " + releaseType;

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
        {;
            var db = new Database();
            var client = db.ConnectToMongoDB();
            var genericUser = new Users(client);
            Console.WriteLine(genericUser.FindDocument()); 
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