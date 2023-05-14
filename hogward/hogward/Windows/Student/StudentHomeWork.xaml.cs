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
using hogward.Classes;

namespace hogward.Windows.Student
{
    public partial class StudentHomeWork : Window
    {

        public StudentHomeWork()
        {
            InitializeComponent();
            HomeWorkSeter();
        }
        public void HomeWorkSeter()
        {
            string[] teacher = File.ReadAllText("LessonForHomeWork.txt").Split("-")[1].Split(" ");
            var students = Program.StudentDetecter();
            var detail = Program.UserFounder("student");
            var lessons = Program.lessonSelectedDetecter();
            int index = Convert.ToInt32(detail[2]);
            string Lesson = File.ReadAllText("LessonForHomeWork.txt").Split("-")[0];
            for (int i = 0; i < lessons.Length; i++)
            {
                for (int j = 0; j < lessons[i].Students.Count; j++)
                {
                    if (lessons[i].Teacher[1] == teacher[1] && lessons[i].Teacher[0] == teacher[0] && lessons[i].Name == Lesson && lessons[i].Students[j].Username == students[index].Username && lessons[i].Students[j].Password == students[index].Password)
                    {
                        Title.Text = lessons[i].homework.Title;
                        Point.Text = Convert.ToString(lessons[i].homework.Point);
                        DeadLine.Text = lessons[i].homework.DeadLine;
                        if (lessons[i].homework.Ans == null)
                            break;
                        int count = lessons[i].homework.Ans.Count;
                        ANS.Text = lessons[i].homework.Ans[count -1].Answers;
                        break;
                    }
                }
            }
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            var students = Program.StudentDetecter();
            var detail = Program.UserFounder("student");
            var lessons = Program.lessonSelectedDetecter();
            int index = Convert.ToInt32(detail[2]);
            string Lesson = File.ReadAllText("LessonForHomeWork.txt").Split("-")[0];
            string[] teacher = File.ReadAllText("LessonForHomeWork.txt").Split("-")[1].Split(" ");
            Answer answer = new();
            for (int i = 0; i < lessons.Length; i++)
            {
                for (int j = 0; j < lessons[i].Students.Count; j++)
                {
                    if (lessons[i].Teacher[1] == teacher[1] &&lessons[i].Teacher[0] == teacher[0] && lessons[i].Name == Lesson && lessons[i].Students[j].Username == students[index].Username && lessons[i].Students[j].Password == students[index].Password)
                    {
                        answer.Username = students[j].Username;
                        answer.Password = students[j].Password;
                        answer.Answers = ANS.Text;
                        lessons[i].homework.Ans = new();
                        lessons[i].homework.Ans.Add(answer);
                        File.WriteAllText("LessonSelected.json", JsonConvert.SerializeObject(lessons));
                        File.WriteAllText("Error.txt", "HomeWork Sended Sucssesfully");
                        Error_page error_Page = new Error_page();
                        error_Page.Show();
                        this.Close();
                        break;
                    }
                }
            }
        }
    }
}
