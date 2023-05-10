using hogward.Classes;
using hogward.Windows;
using hogward.Windows.Professor;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
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
            var authorizePersons = Program.AuthorizePersonsDetecter();

            if (Type.Text == "Dumbledore")
            {
                if (UserName.Text == "Admin" && PassWord.Text == "Admin")
                {
                    DumbledoreWorkDesk dumbledoreWorkDesk = new DumbledoreWorkDesk();
                    dumbledoreWorkDesk.Show();
                    Program.Writer("-1", "-1");
                    this.Close();

                }
                else
                {
                    throw new System.Exception();
                }
            }
            else if (Type.Text == "Professor")
            {
                int count = Program.LoginCheck("teacher", UserName.Text, PassWord.Text);
                if (count == 1)
                {
                    ProfessorDesk professorDesk = new ProfessorDesk();
                    professorDesk.Show();
                    this.Close();
                }
                else if (count == -1)
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
            else if (Type.Text == "Student")
            {
                int count = Program.LoginCheck("student", UserName.Text, PassWord.Text);
                if (count == 1)
                {
                    StudentDesk studentDesk = new StudentDesk();
                    studentDesk.Show();
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
    }
}

