using Radium_Launcher_For_Windows.Controller;
using Radium_Launcher_For_Windows.Server.Database;
using System.Windows;
using System.IO;
using MongoDB.Bson;

namespace Radium_Launcher_For_Windows.View
{
    /// <summary>
    /// Interaction logic for Application.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        private readonly string notAvaialble = "";
        private readonly Runner webRunner = new Runner();

        /// <summary>
        /// La deuxième fenêtre
        /// </summary>
        public Page2()
        {
            Translator translator = new Translator(this);
            notAvaialble = translator.TranslateToString("Login Not Availaible Message");
            InitializeComponent();
        }

        private void Go_To_Website_Click(object sender, RoutedEventArgs e)
        {
            var website = new Website();
            website.Show();
        }

        private void Go_To_Source_Code_Click(object sender, RoutedEventArgs e)
        {
            webRunner.SetPath("https://github.com/xgui4/Radium.Laucher");
            webRunner.OpenBrowser();
            webRunner.Clear();
        }

        private void TBD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this is a future feature");
        }

        private void downloadMinecraft_launcher_Click(object sender, RoutedEventArgs e)
        {
            webRunner.SetPath("https://www.minecraft.net/download");
            webRunner.OpenBrowser();
            webRunner.Clear();
        }

        private void Go_To_Config_Click(object sender, RoutedEventArgs e)
        {
            ConfigPanel configPanel = new ConfigPanel();
            Config.Navigate(configPanel);
        }

        private void downloadMinecraft_Click(object sender, RoutedEventArgs e)
        {
            webRunner.SetPath("https://www.minecraft.net/fr-ca/store/minecraft-java-bedrock-edition-pc");
            webRunner.OpenBrowser();
            webRunner.Clear();
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
    }
}
