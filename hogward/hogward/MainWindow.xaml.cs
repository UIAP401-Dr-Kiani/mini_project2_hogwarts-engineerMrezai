using System.Windows;
namespace hogward
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Dumbledore_OnClick(object sender, RoutedEventArgs e)
        {
            DumbledoreLogin dumbledore = new DumbledoreLogin();
            dumbledore.Show();
        }

        private void Teachers_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Students_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
