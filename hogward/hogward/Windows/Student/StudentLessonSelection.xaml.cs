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
            string[] resualt = Program.UserFounder();
            StudentLessonsSelection.Title = resualt[0] + " " + resualt[1];
            int count = Convert.ToInt32(resualt[2]);
            AllowClass(studetns[count].Term);
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
            string[] resualt = Program.UserFounder();
            var studetns = Program.StudentDetecter();
            studetns[Convert.ToInt16(resualt[2])].lessens = new Lesson[8];
            studetns[Convert.ToInt16(resualt[2])].plant = new string[2];
            if (Chemistry.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[0] = new();
                var Input = Chemistry.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[0].Name = "Chemistry";
                studetns[Convert.ToInt16(resualt[2])].lessens[0].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[0].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[0].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[0].Time[1] = Input[3];
            }
            if (BotanicalOne.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[1] = new();
                var Input = BotanicalOne.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[1].Name = "BotanicalOne";
                studetns[Convert.ToInt16(resualt[2])].lessens[1].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[1].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[1].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[1].Time[1] = Input[3];
            }
            if (BotanicalTwo.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[2] = new();
                var Input = BotanicalTwo.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[2].Name = "BotanicalTwo";
                studetns[Convert.ToInt16(resualt[2])].lessens[2].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[2].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[2].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[2].Time[1] = Input[3];
            }
            if (BotanicalThree.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[3] = new();
                var Input = BotanicalThree.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[3].Name = "BotanicalThree";
                studetns[Convert.ToInt16(resualt[2])].lessens[3].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[3].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[3].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[3].Time[1] = Input[3];
            }
            if(BotanicalFour.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[4] = new();
                var Input = BotanicalFour.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[4].Name = "BotanicalFour";
                studetns[Convert.ToInt16(resualt[2])].lessens[4].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[4].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[4].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[4].Time[1] = Input[3];
            }
            if(Occultism.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[5] = new();
                var Input = Occultism.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[5].Name = "Occultism";
                studetns[Convert.ToInt16(resualt[2])].lessens[5].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[5].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[5].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[5].Time[1] = Input[3];
            }
            if(Sport.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[6] = new();
                var Input = Sport.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[6].Name = "Sport";
                studetns[Convert.ToInt16(resualt[2])].lessens[6].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[6].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[6].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[6].Time[1] = Input[3];

            }
            if(Plant.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].lessens[7] = new();
                var Input = Plant.Text.Split(" ");
                studetns[Convert.ToInt16(resualt[2])].lessens[7].Name = "Plant";
                studetns[Convert.ToInt16(resualt[2])].lessens[7].Teacher[0] = Input[0];
                studetns[Convert.ToInt16(resualt[2])].lessens[7].Teacher[1] = Input[1];
                studetns[Convert.ToInt16(resualt[2])].lessens[7].Time[0] = Input[2];
                studetns[Convert.ToInt16(resualt[2])].lessens[7].Time[1] = Input[3];
            }
            File.WriteAllText("Students.json", JsonConvert.SerializeObject(studetns));
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
