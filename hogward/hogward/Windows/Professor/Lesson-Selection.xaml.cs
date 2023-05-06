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

namespace hogward.Windows.Professor
{
    /// <summary>
    /// Interaction logic for Lesson_Selection.xaml
    /// </summary>
    public partial class Lesson_Selection : Window
    {
        int count = -1;
        public Lesson_Selection()
        {
            InitializeComponent();
            var professors = Program.ProfessorDetecter();
            string[] Person = File.ReadAllText("UserIndex.txt").Split(" ");
            for (int i = 0; i < professors.Length; i++)
            {
                if (professors[i].Username == Person[0] && professors[i].Password == (Person[1]))
                {
                    ID.Text = professors[i].Name + " " + professors[i].Family;
                    count = i;
                    break;
                }
            }
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Lesson1 = lesson1.Text + " " + lesson1Date1.Text + "-" + lesson1Time1.Text + " " + lesson1Date2.Text + "-" + lesson1Time2.Text;
                string Lesson2 = lesson2.Text + " " + lesson2Date1.Text + "-" + lesson2Time1.Text + " " + lesson2Date2.Text + "-" + lesson2Time2.Text;
                string Lesson3 = lesson3.Text + " " + lesson3Date1.Text + "-" + lesson3Time1.Text + " " + lesson1Date2.Text + "-" + lesson1Time2.Text;
                Program.ProfessorSelector(Lesson1, Lesson2, Lesson3 , count);
            }
            catch
            {   
                Error_page error_Page = new Error_page();
                error_Page.Show();
            }
        }
    }
}
