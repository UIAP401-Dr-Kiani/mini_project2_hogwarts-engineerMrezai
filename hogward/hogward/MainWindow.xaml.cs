using hogward.Windows;
using hogward.Windows.Professor;
using Newtonsoft.Json;
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
            var authorizePersons = Program.AuthorizePersonsDetecter();
            try
            { 
                if (Type.Text == "Dumbledore")
                {
                    if (UserName.Text == "Admin" && PassWord.Text == "Admin")
                    {
                        DumbledoreWorkDesk dumbledoreWorkDesk = new DumbledoreWorkDesk();
                        dumbledoreWorkDesk.Show();
                        Program.Writer("-1" , "-1");
                        this.Close();

                    }
                    else
                    {
                        throw new System.Exception();
                    }
                }
                else if (Type.Text == "Professor")
                {
                    Program.LoginCheck("teacher", UserName.Text, PassWord.Text);
                    ProfessorDesk professorDesk = new ProfessorDesk();
                    professorDesk.Show();
                    this.Close();
                }
                else if (Type.Text == "Student")
                {
                    Program.LoginCheck("student",UserName.Text,PassWord.Text);
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

