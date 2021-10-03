using System.Windows;
using System.Windows.Input;
using Vikings.UserControls.ViewModels;

namespace Vikings.UserControls.Views
{
    /// <summary>
    /// Interaction logic for NewInventoryItemWindow.xaml
    /// </summary>
    public partial class InventoryItemWindow : Window
    {
        public InventoryItemWindow()
        {
            InitializeComponent();
            NewInventoryItemViewModel viewModel = new NewInventoryItemViewModel();
            this.DataContext = viewModel;
            if(viewModel.CloseAction == null)
            {
                viewModel.CloseAction = new System.Action(() =>
                {
                    this.Close();
                });
            }
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
