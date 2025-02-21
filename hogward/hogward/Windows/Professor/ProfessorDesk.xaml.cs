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
            ListLesson.ItemsSource = Program.ProfessorLessonFinder();
            var professors = Program.ProfessorDetecter();
            var detail = Program.UserFounder("teacher");
            index = Convert.ToInt32(detail[2]);
            ID.Text = professors[index].Name + " " + professors[index].Family;
        }

        private void LessonSelction_Click(object sender, RoutedEventArgs e)
        {
            LessonSelction.Visibility = Visibility.Hidden;
            HomeWork.Visibility = Visibility.Hidden;
            Logout.Visibility = Visibility.Hidden;
            LessonSelectionGrid.Visibility = Visibility.Visible;

        }

        private void HomeWork_Click(object sender, RoutedEventArgs e)
        {
            LessonSelction.Visibility = Visibility.Hidden;
            HomeWork.Visibility = Visibility.Hidden;
            Logout.Visibility = Visibility.Hidden;
            HomeWorkGrid.Visibility = Visibility.Visible;
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
            if( lesson1.Text == null || lesson2.Text == null || lesson3.Text == null )
            {
                using (var writer = new StreamWriter("Error.txt"))
                    writer.WriteLine("Same lesson choise in same date and same time");
            }
            detail = Program.ProfessorSelector(Lesson1, Lesson2, Lesson3, index);  
            if (detail == 1)
            {
                using (var writer = new StreamWriter("Error.txt"))
                    writer.WriteLine("Lessons Saved sucssesfully");
                LessonSelction.Visibility = Visibility.Visible;
                HomeWork.Visibility = Visibility.Visible;
                Logout.Visibility = Visibility.Visible;
                LessonSelectionGrid.Visibility = Visibility.Hidden;
            }
            else
            {
                using (var writer = new StreamWriter("Error.txt"))
                    writer.WriteLine("Same lesson choise in same date and same time");
            }
            error_Page.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            LessonSelction.Visibility = Visibility.Visible;
            HomeWork.Visibility = Visibility.Visible;
            Logout.Visibility = Visibility.Visible;
            LessonSelectionGrid.Visibility = Visibility.Hidden;
            HomeWorkGrid.Visibility = Visibility.Hidden;
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            Program.ProfessorHomeWorkWriter(DeadLine.Text, ListLesson.Text, Title.Text, Convert.ToInt16(Point.Text)); LessonSelction.Visibility = Visibility.Visible;
            HomeWork.Visibility = Visibility.Visible;
            Logout.Visibility = Visibility.Visible;
            LessonSelction.Visibility = Visibility.Visible;
            HomeWorkGrid.Visibility = Visibility.Hidden;
        }
    }
}
