using System;
using System.Collections.Generic;
using System.IO;
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

namespace hogward.Windows.Professor
{
    public partial class ProfessorDesk : Window
    {
        public int index = -1;
        public ProfessorDesk()
        {
            InitializeComponent();
            var professors = Program.ProfessorDetecter();
            var detail = Program.UserFounder("teacher");
            index = Convert.ToInt32(detail[2]);
            ID.Text = professors[index].Name + " " + professors[index].Family;
        }

        private void LessonSelction_Click(object sender, RoutedEventArgs e)
        {
            Lesson.Visibility = Visibility.Visible;
            FirstClass.Visibility = Visibility.Visible;
            FirstDay.Visibility = Visibility.Visible;
            SecondClass.Visibility = Visibility.Visible;
            SecondDay.Visibility = Visibility.Visible;
            lesson1.Visibility = Visibility.Visible;
            lesson1Date1.Visibility = Visibility.Visible;
            lesson1Date2.Visibility = Visibility.Visible;
            lesson1Time1.Visibility = Visibility.Visible;
            lesson1Time2.Visibility = Visibility.Visible;
            lesson2.Visibility = Visibility.Visible;
            lesson2Date1.Visibility = Visibility.Visible;
            lesson2Date2.Visibility = Visibility.Visible;
            lesson2Time1.Visibility = Visibility.Visible;
            lesson2Time2.Visibility = Visibility.Visible;
            lesson3.Visibility = Visibility.Visible;
            lesson3Date1.Visibility = Visibility.Visible;
            lesson3Date2.Visibility = Visibility.Visible;
            lesson3Time1.Visibility = Visibility.Visible;
            lesson3Time2.Visibility = Visibility.Visible;
            Select.Visibility = Visibility.Visible;
            
        }

        private void HomeWork_Click(object sender, RoutedEventArgs e)
        {
            ProfessorHomeWork professorHomeWork = new ProfessorHomeWork();
            professorHomeWork.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            Error_page error_Page = new Error_page();
            int detail = 0;
            string Lesson1 = lesson1.Text + " " + lesson1Date1.Text + "-" + lesson1Time1.Text + " " + lesson1Date2.Text + "-" + lesson1Time2.Text;
            string Lesson2 = lesson2.Text + " " + lesson2Date1.Text + "-" + lesson2Time1.Text + " " + lesson2Date2.Text + "-" + lesson2Time2.Text;
            string Lesson3 = lesson3.Text + " " + lesson3Date1.Text + "-" + lesson3Time1.Text + " " + lesson1Date2.Text + "-" + lesson1Time2.Text;
            detail = Program.ProfessorSelector(Lesson1, Lesson2, Lesson3, index);
                
            
            
            if (detail == 1)
            {
                using (var writer = new StreamWriter("Error.txt"))
                    writer.WriteLine("Lessons Saved sucssesfully");
                Lesson.Visibility = Visibility.Hidden;
                FirstClass.Visibility = Visibility.Hidden;
                FirstDay.Visibility = Visibility.Hidden;
                SecondClass.Visibility = Visibility.Hidden;
                SecondDay.Visibility = Visibility.Hidden;
                lesson1.Visibility = Visibility.Hidden;
                lesson1Date1.Visibility = Visibility.Hidden;
                lesson1Date2.Visibility = Visibility.Hidden;
                lesson1Time1.Visibility = Visibility.Hidden;
                lesson1Time2.Visibility = Visibility.Hidden;
                lesson2.Visibility = Visibility.Hidden;
                lesson2Date1.Visibility = Visibility.Hidden;
                lesson2Date2.Visibility = Visibility.Hidden;
                lesson2Time1.Visibility = Visibility.Hidden;
                lesson2Time2.Visibility = Visibility.Hidden;
                lesson3.Visibility = Visibility.Hidden;
                lesson3Date1.Visibility = Visibility.Hidden;
                lesson3Date2.Visibility = Visibility.Hidden;
                lesson3Time1.Visibility = Visibility.Hidden;
                lesson3Time2.Visibility = Visibility.Hidden;
                Select.Visibility = Visibility.Hidden;
            }
            else
            {
                using (var writer = new StreamWriter("Error.txt"))
                    writer.WriteLine("Same lesson choise in same date and same time");
            }
            error_Page.Show();
        }
    }
}
