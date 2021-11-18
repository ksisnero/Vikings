using System.Windows;
using Vikings.UserControls.Views;

namespace Vikings
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var welcomeWindow = new WelcomeWindow();
            welcomeWindow.ShowDialog();
        }
    }
}
