using hogward.Classes;
using hogward.Windows.Professor;
using hogward.Windows.Student;
using Newtonsoft.Json;
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

namespace hogward.Windows;


public partial class StudentDesk : Window
{

    string[] TTrain = train.Train();
    public StudentDesk()
    {
        InitializeComponent();
        Task.Factory.StartNew(train.TravelTrain);
        int status = train.TrainCheack();
        if (status == 0)
        {
            Train.IsEnabled = false;
        }
        else
        {
            Train.IsEnabled = true;
            if (TTrain[0] == "Next Tomarow 8:00")
            {
                TrainTime.Text = "Next Tomarow 8:00";
                Train.IsEnabled = false;
            }
            else
            {
                TrainTime.Text = (Convert.ToInt16(TTrain[0]) / 60) + ":" + (Convert.ToInt16(TTrain[0]) % 60);
            }
        }
        
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
        var students = Program.StudentDetecter();
        var index = Program.UserFounder("student");
        students[Convert.ToInt16(index[2])].TrainNum = Convert.ToInt16(TTrain[1]);
        File.WriteAllText("Students.json", JsonConvert.SerializeObject(students));
        File.WriteAllText("Error.txt", "You have successfully boarded the train");
        Error_page error_Page = new Error_page();
        error_Page.Show();
    }

    private void Chart_Click(object sender, RoutedEventArgs e)
    {
        Chart chart = new Chart();
        chart.Show();
    }
}
