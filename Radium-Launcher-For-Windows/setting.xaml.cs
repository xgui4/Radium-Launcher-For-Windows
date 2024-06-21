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
    /// Le code behind qui fait fonctionner la page Setting. 
    /// </summary>
    public partial class Setting : Window
    {
        SystemManagement sys;
        public Setting()
        {
            InitializeComponent();
        }

        private void downloadMinecraft_Copy1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Le site est prévue pour plus tard.");
        }

        private void downloadMinecraft_Copy2_Click(object sender, RoutedEventArgs e)
        {
            sys = new SystemManagement();

            sys.OpenBrowser("https://github.com/xgui4/Radium-Launcher");
        }

        private void downloadMinecraft_Copy6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("this is a future feature");
        }
        private void downloadMinecraft_launcher_Click(object sender, RoutedEventArgs e)
        {
            sys = new SystemManagement();

            sys.OpenBrowser("https://www.minecraft.net/download"); 
        }

        private void downloadMinecraft_Copy5_Click(object sender, RoutedEventArgs e)
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
