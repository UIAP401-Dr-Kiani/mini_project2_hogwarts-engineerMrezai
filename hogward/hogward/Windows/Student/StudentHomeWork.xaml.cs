using System;
using System.Collections.Generic;
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
using System.IO;
using Newtonsoft.Json;

namespace hogward.Windows.Student
{
    /// <summary>
    /// Interaction logic for StudentHomeWork.xaml
    /// </summary>
    public partial class StudentHomeWork : Window
    {

        public StudentHomeWork()
        {
            InitializeComponent();
            HomeWorkSeter();
        }
        public void HomeWorkSeter()
        {
            var students = Program.StudentDetecter();
            var detail = Program.UserFounder("student");
            int index = Convert.ToInt32(detail[2]);
            string Lesson = File.ReadAllText("LessonForHomeWork.txt").Split("-")[0];
            for(int i = 0; i < students[index].lessens.Length;i++)
            {
                if (students[index].lessens[i] == null)
                    continue;
                if (Lesson == students[index].lessens[i].Name)
                {
                    if (students[index].lessens[i].homework == null)
                        continue;
                    Title.Text = students[index].lessens[i].homework.Title;
                    Point.Text = Convert.ToString(students[index].lessens[i].homework.Point);
                    DeadLine.Text = students[index].lessens[i].homework.DeadLine;
                    ANS.Text = students[index].lessens[i].homework.Ans;
                    break;
                }
            }
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            var students = Program.StudentDetecter();
            var detail = Program.UserFounder("student");
            int index = Convert.ToInt32(detail[2]);
            string Lesson = File.ReadAllText("LessonForHomeWork.txt").Split("-")[0];
            for (int i = 0; i < students[index].lessens.Length; i++)
            {
                if (students[index].lessens[i] == null)
                    continue;
                if (Lesson == students[index].lessens[i].Name)
                {
                    if (students[index].lessens[i].homework == null)
                        continue;
                    else
                    {
                        students[index].lessens[i].homework.Ans = ANS.Text;
                        File.WriteAllText("Students.json", JsonConvert.SerializeObject(students));
                        File.WriteAllText("Error.txt", "HomeWork Sended Sucssesfully");
                        Error_page error_Page = new Error_page();
                        error_Page.Show();
                        this.Close();
                    }

                }
            }
          
        }
    }
}
