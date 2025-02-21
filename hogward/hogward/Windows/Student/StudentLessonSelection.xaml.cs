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
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace hogward.Windows.Student
{
    public partial class StudentLessonSelection : Window
    {
        public StudentLessonSelection()
        {
            InitializeComponent();

            var studetns = Program.StudentDetecter();
            string[] resualt = Program.UserFounder("student");
            StudentLessonsSelection.Title = resualt[0] + " " + resualt[1];
            int index = Convert.ToInt32(resualt[2]);
            AllowClass(studetns[index].Term);
        }
        public void AllowClass(int term)
        {
            var lessons = Program.LessonDetecter();
            for (int i = 0; i < lessons.Length; i++)
            {
                if (lessons[i].PresentationSemester == term)
                {
                    if (lessons[i].Name == "Chemistry")
                    {
                        Chemistry.IsEnabled = true;
                        Chemistry.ItemsSource = Program.AllowProfesorLesson("Chemistry");
                    }
                    else if (lessons[i].Name == "BotanicalOne")
                    {
                        BotanicalOne.IsEnabled = true;
                        BotanicalOne.ItemsSource = Program.AllowProfesorLesson("BotanicalOne");
                    }
                    else if (lessons[i].Name == "BotanicalTwo")
                    {
                        BotanicalTwo.IsEnabled = true;
                        BotanicalTwo.ItemsSource = Program.AllowProfesorLesson("BotanicalTwo");
                    }
                    else if (lessons[i].Name == "BotanicalThree")
                    {
                        BotanicalThree.IsEnabled = true;
                        BotanicalThree.ItemsSource = Program.AllowProfesorLesson("BotanicalThree");
                    }
                    else if (lessons[i].Name == "BotanicalFour")
                    {
                        BotanicalFour.IsEnabled = true;
                        BotanicalFour.ItemsSource = Program.AllowProfesorLesson("BotanicalFour");
                    }
                    else if (lessons[i].Name == "Occultism")
                    {
                        Occultism.IsEnabled = true;
                        Occultism.ItemsSource = Program.AllowProfesorLesson("Occultism");
                    }
                    else if (lessons[i].Name == "Sport")
                    {
                        Sport.IsEnabled = true;
                        Sport.ItemsSource = Program.AllowProfesorLesson("Sport");
                    }
                    else if (lessons[i].Name == "Plant")
                    {
                        Plant.IsEnabled = true;
                        Plant.ItemsSource = Program.AllowProfesorLesson("Plant");
                    }
                }
            }
        }
        private void Select_Click(object sender, RoutedEventArgs e)
        {
            string[] resualt = Program.UserFounder("student");
            var studetns = Program.StudentDetecter();
            var lessons = Program.lessonSelectedDetecter();
            int index = Convert.ToInt16(resualt[2]);
            
            if (Chemistry.IsEnabled == true)
            {
                var LessonDetail = Chemistry.Text.Split(" ");
                for (int i =0;i<lessons.Length;i++)
                {
                    if (lessons[i].Name == "Chemistry" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            if (BotanicalOne.IsEnabled == true)
            {
                var LessonDetail = BotanicalOne.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "BotanicalOne" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            if (BotanicalTwo.IsEnabled == true)
            {
                var LessonDetail = BotanicalTwo.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "BotanicalTwo" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            if (BotanicalThree.IsEnabled == true)
            {
                var LessonDetail = BotanicalThree.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "BotanicalThree" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            if (BotanicalFour.IsEnabled == true)
            {
                var LessonDetail = BotanicalFour.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "BotanicalFour" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            if (Occultism.IsEnabled == true)
            {
                var LessonDetail = Occultism.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "Occultism" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            if (Sport.IsEnabled == true)
            {
                var LessonDetail = Sport.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "Sport" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }

            }
            if (Plant.IsEnabled == true)
            {
                var LessonDetail = Plant.Text.Split(" ");
                for (int i = 0; i < lessons.Length; i++)
                {
                    if (lessons[i].Name == "Plant" && lessons[i].Teacher[0] == LessonDetail[0] && lessons[i].Teacher[1] == LessonDetail[1] && lessons[i].Time[0] == LessonDetail[2])
                    {
                        lessons[i].Students.Add(studetns[index]);
                    }
                }
            }
            
            File.WriteAllText("LessonSelected.json", JsonConvert.SerializeObject(lessons));
            using (var writer = new StreamWriter("Error.txt"))
            {
                writer.Write("Lessons seleced sucssefully");
            }
            Error_page error_Page = new Error_page();
            error_Page.Show();
            this.Close();
        }
    }
}
