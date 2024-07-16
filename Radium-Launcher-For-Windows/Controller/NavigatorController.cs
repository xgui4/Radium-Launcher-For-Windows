using Radium_Launcher;
using Radium_Launcher_For_Windows.View;

namespace Radium_Launcher_For_Windows.Controller
{
    public class NavigatorController
    {
        private NavigatorController() { }

        public static void NavigateToPage2(MainWindow window)
        {
            var page2 = new Page2();
            page2.Width = window.Width;
            page2.Height = window.Height;
            page2.Title = window.Title;
            window.Hide();
            page2.Show();
            page2.Closed += (s, e) =>
            {
                window.Show();
            };
        }
    }
}
