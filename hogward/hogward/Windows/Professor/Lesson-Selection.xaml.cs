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
        public Lesson_Selection()
        {
            int count = -1;
            var professors = Program.AuthorizePersonsDetecter("teacher");
            string[] Person = File.ReadAllText("UserIndex.txt").Split(" ");
            for (int i = 0;i< professors.Length;i++)
            {
                if (professors[i].Username == Person[0] && professors[i].Password == (Person[1]))
                {
                    count = i;
                    break;
                }
            }
            InitializeComponent();
            Profesore.Text = professors[count].Name + " " + professors[count].Family;
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Program.ProfessorSelector(lesson1.Text, lesson2.Text, lesson3.Text);
            }
            catch
            {   
                
            }
        }
    }
}
