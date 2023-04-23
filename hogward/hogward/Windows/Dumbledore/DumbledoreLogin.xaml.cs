using hogward.Windows;
using System.IO;
using System.Windows;
using System.Windows.Interop;

namespace hogward;

public partial class DumbledoreLogin : Window
{
    public DumbledoreLogin()
    {
        InitializeComponent();
    }

    private void Students_OnClick(object sender, RoutedEventArgs e)
    {
        if (UserName.Text == "Admin" && PassWord.Text == "Admin")
        {
            DumbledoreWorkDesk dumbledoreWorkDesk = new DumbledoreWorkDesk();
            dumbledoreWorkDesk.Show();
            this.Close();
        }
        else
        {
            using (StreamWriter ln = new StreamWriter("Error.txt"))
            {
                ln.WriteLine("UserName or Password not Found");
                ln.Close();
            }
            Error_page error_Page = new Error_page();
            error_Page.Show();
        }
    }
}