using hogward.Windows;
using System.IO;
using System.Windows;
namespace hogward
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Students_OnClick(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (Type.Text == "Dumbledore")
                {
                    if (UserName.Text == "Admin" && PassWord.Text == "Admin")
                    {
                        DumbledoreWorkDesk dumbledoreWorkDesk = new DumbledoreWorkDesk();
                        dumbledoreWorkDesk.Show();
                        this.Close();
                    }
                    else
                    {
                        throw new System.Exception();
                    }
                }
                else if (Type.Text == "Professor")
                {
                    if (UserName.Text == "" && PassWord.Text == "")
                    { }
                    else
                    { 
                        throw new System.Exception(); 
                    }
                }
                else if (Type.Text == "Student")
                {
                    if (UserName.Text == "" && PassWord.Text == "")
                    { }
                    else
                    {
                        throw new System.Exception(); 
                    }
                }
            }
            catch
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
}

