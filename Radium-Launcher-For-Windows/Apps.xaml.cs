using Radium_Launcher_For_Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;

namespace Radium_Launcher
{
    /// <summary>
    /// Le code behind qui fait fonctionner la page Apps. 
    /// </summary>
    public partial class Apps : Window
    {
        SystemManagement sys;
        public Apps()
        {
            InitializeComponent();
        }

        private void Go_To_Website_Click(object sender, RoutedEventArgs e)
        {
            Website website = new Website();
            website.Show(); 
        }
        
        private void Go_To_Source_Code_Click(object sender, RoutedEventArgs e)
        {
            sys = new SystemManagement();

            sys.OpenBrowser("https://github.com/xgui4/Radium-Launcher");
        }

        private void TBD_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this is a future feature");
        }
        private void downloadMinecraft_launcher_Click(object sender, RoutedEventArgs e)
        {
            sys = new SystemManagement();

            sys.OpenBrowser("https://www.minecraft.net/download"); 
        }

        private void Go_To_Config_Click(object sender, RoutedEventArgs e)
        {
            //File.Open("App.Config", FileMode.Open, FileAccess.Write, FileShare.None);
            MessageBox.Show("this is a future feature");
        }

        private void downloadMinecraft_Click(object sender, RoutedEventArgs e)
        {
            sys = new SystemManagement();

            sys.OpenBrowser("https://www.minecraft.net/fr-ca/store/minecraft-java-bedrock-edition-pc"); 
        }
    }
}
