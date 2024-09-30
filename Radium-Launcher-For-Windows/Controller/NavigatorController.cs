using Radium_Launcher;
using Radium_Launcher_For_Windows.View;

namespace Radium_Launcher_For_Windows.Controller
{
    /// <summary>
    /// Le navigateur principale
    /// </summary>
    public class NavigatorController
    {
        private NavigatorController() { }

        /// <summary>
        /// Naviguer vers la page 2
        /// </summary>
        /// <param name="window"></param>
        public static void NavigateToPage2(MainWindow window)
        {
            var page2 = new Page2() {
                Width = window.Width,
                Height = window.Height,
                Title = window.Title,
            };
            window.Hide();
            page2.Show();
            page2.Closed += (s, e) =>
            {
                window.Show();
            };
        }
    }
}
