using hogward.Classes;
using hogward.Windows.Professor;
using hogward.Windows.Student;
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

namespace hogward.Windows;

/// <summary>
/// Interaction logic for StudentDesk.xaml
/// </summary>
public partial class StudentDesk : Window
{
    public StudentDesk()
    {
        InitializeComponent();
        TrainTime.Text = train.Train();
    }

    private void email_Click(object sender, RoutedEventArgs e)
    {
        Email eemail = new Email();
        eemail.Show();

    }

    private void Lesson_Selction_Click(object sender, RoutedEventArgs e)
    {
        StudentLessonSelection studentLessonSelection = new StudentLessonSelection();
        studentLessonSelection.Show();
    }

    private void Train_Click(object sender, RoutedEventArgs e)
    {
        
    }
}
