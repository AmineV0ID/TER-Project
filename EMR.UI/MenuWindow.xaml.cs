using System.Windows;
using System.Windows.Input;
using EMR.UI.MVVM.ViewModel;

namespace EMR.UI
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void ExitAppButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            ///Close();
        }
    }
}
