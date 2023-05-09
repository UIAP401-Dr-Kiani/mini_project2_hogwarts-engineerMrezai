﻿using System;
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
            studetns[Convert.ToInt16(resualt[2])].plant = new string[2];
            if (Chemistry.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].plant[0] = "Chemistry" + " " + Chemistry.Text + "-";
            }
            if (BotanicalOne.IsEnabled == true)
            {

                studetns[Convert.ToInt16(resualt[2])].plant[1] = "BotanicalOne" + " " + BotanicalOne.Text + "-";
            }
            if (BotanicalTwo.IsEnabled == true)
            {

                studetns[Convert.ToInt16(resualt[2])].plant[2] = "BotanicalTwo" + " " + BotanicalTwo.Text + "-";
            }
            if (BotanicalThree.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].plant[3] = "BotanicalThree" + " " + BotanicalThree.Text + "-";
            }
            if(BotanicalFour.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].plant[4] = "BotanicalFour" + " " + BotanicalFour.Text + "-";
            }
            if(Occultism.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].plant[5] = "Occultism" + " " + Occultism.Text + "-";
            }
            if(Sport.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].plant[6] = "Sport" + " " + Sport.Text + "-";
            }
            if(Plant.IsEnabled == true)
            {
                studetns[Convert.ToInt16(resualt[2])].plant[7] = "Plant" + " " + Plant.Text + "-";
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
