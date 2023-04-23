using System;
using System.Collections.Generic;
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

namespace hogward.Windows
{
    /// <summary>
    /// Interaction logic for Error_page.xaml
    /// </summary>
    public partial class Error_page : Window
    {
        public Error_page()
        {
            InitializeComponent();
            ErrorText.Text = File.ReadAllText("Error.txt");
            
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
