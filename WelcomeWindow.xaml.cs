using System;
using System.Windows;

namespace Vikings.UserControls.Views
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        private bool hasPlayerFile;

        public WelcomeWindow()
        {
            InitializeComponent();
            this.Closed += WelcomeWindow_Closed;
        }

        protected void WelcomeWindow_Closed(object sender, EventArgs e)
        {
            if(hasPlayerFile)
            {
                MainWindow mainWindow = new MainWindow();
                MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
                mainWindow.DataContext = mainWindowViewModel;

                Application.Current.MainWindow = mainWindow;
                mainWindow.Show();
            }
        }

        private void GetPlayerFile(object sender, RoutedEventArgs e)
        {
            var playerFileHelper = new PlayerFileHelper();
            hasPlayerFile = playerFileHelper.OpenPlayerFile();

            if(hasPlayerFile)
            {
                this.Close();
                
            } else
            {
                MessageBox.Show("Error occured while trying to get player file. Please try again", "Oh no!", MessageBoxButton.OK);
            }
        }

        private void CreateNewPlayerFile(object sender, RoutedEventArgs e)
        {
            var playerFileHelper = new PlayerFileHelper();
            hasPlayerFile = playerFileHelper.CreateNewPlayerFile();

            if (hasPlayerFile)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occured while trying to get player file. Please try again", "Oh no!", MessageBoxButton.OK);
            }
        }
    }
}
