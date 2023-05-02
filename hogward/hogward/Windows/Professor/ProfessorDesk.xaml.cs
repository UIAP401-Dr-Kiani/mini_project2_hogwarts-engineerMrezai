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

namespace hogward.Windows.Professor
{
    public partial class ProfessorDesk : Window
    {
        public ProfessorDesk()
        {
            InitializeComponent();
        }

        private void LessonSelction_Click(object sender, RoutedEventArgs e)
        {
            Lesson_Selection lesson_Selection = new Lesson_Selection();
            lesson_Selection.Show();
        }
    }
}
