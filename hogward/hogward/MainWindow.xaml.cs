using hogward.Windows;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;

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
            List<AuthorizePersons> authorizePersons = program.AuthorizePersonsDetecter();
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
                    program.LoginCheck("teacher", UserName.Text, PassWord.Text);
                    Window window = new Window();
                    window.Show();
                    this.Close();
                }
                else if (Type.Text == "Student")
                {
                    program.LoginCheck("student",UserName.Text,PassWord.Text);
                    StudentDesk studentDesk = new StudentDesk();
                    studentDesk.Show();
                    this.Close();
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

