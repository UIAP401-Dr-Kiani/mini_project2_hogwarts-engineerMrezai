using System.Windows;

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
            dumbledoreWorkDesk.ShowDialog();
        }
        else
        {
            Error.Text = "UserName or Password is Wrong";
        }
    }
}