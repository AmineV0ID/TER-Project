using System.Windows;
using System.Windows.Input;

namespace EMR.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuWindow men = new MenuWindow();
            men.ShowDialog();
        }

        private void ExitAppButton_Click(object sender, RoutedEventArgs e)
        {
            ///System.Windows.Application.Current.Shutdown();
            Close();
        }
    }
}
