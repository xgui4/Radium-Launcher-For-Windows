using Radium_Launcher_For_Windows.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Radium_Launcher_For_Windows.View
{
    /// <summary>
    /// Interaction logic for Application.xaml
    /// </summary>
    public partial class Page2 : Window
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Go_To_Website_Click(object sender, RoutedEventArgs e)
        {
            var website = new Website();
            website.Show();
        }

        private void Go_To_Source_Code_Click(object sender, RoutedEventArgs e)
        {
            var launcher = new Runner("https://github.com/xgui4/Radium.Laucher");

            launcher.OpenBrowser();
        }

        private void TBD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this is a future feature");
        }
        private void downloadMinecraft_launcher_Click(object sender, RoutedEventArgs e)
        {
            var launcher = new Runner("https://www.minecraft.net/download");

            launcher.OpenBrowser();
        }

        private void Go_To_Config_Click(object sender, RoutedEventArgs e)
        {
            ConfigPanel configPanel = new ConfigPanel();
            Config.Navigate(configPanel);
        }

        private void downloadMinecraft_Click(object sender, RoutedEventArgs e)
        {
            var launcher = new Runner("https://www.minecraft.net/fr-ca/store/minecraft-java-bedrock-edition-pc");

            launcher.OpenBrowser();
        }
    }
}
