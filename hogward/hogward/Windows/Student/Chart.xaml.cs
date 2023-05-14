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
using System.Windows.Automation.Peers;

namespace hogward.Windows.Student
{
    public partial class Chart : Window
    {
        public Chart()
        {
            InitializeComponent();
            ChartEnabler();
        }
        public void ChartEnabler()
        {
            var students = Program.StudentDetecter();
            var detail = Program.UserFounder("student");
            var lessons = Program.lessonSelectedDetecter();
            int index = Convert.ToInt32(detail[2]);
            for( int i = 0; i < lessons.Length; i++ )
            {
                for(int j=0;j< lessons[i].Students.Count;j++)
                {
                    if (lessons[i].Students[j].Username == students[index].Username && lessons[i].Students[j].Password == students[index].Password)
                    {
                        for (int k = 0; k < lessons[i].Time.Length; k++ ) 
                        {
                            string[] Time = lessons[i].Time[k].Split("-");
                            if (Time[0] == "Saturday")
                            {
                                if (Time[1] == "8:00")
                                {
                                    SA810.IsEnabled = true;
                                    SA810.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "10:00")
                                {
                                    SA1012.IsEnabled = true;
                                    SA1012.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "14:00")
                                {
                                    SA1416.IsEnabled = true;
                                    SA1416.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "16:00")
                                {
                                    SA1618.IsEnabled = true;
                                    SA1618.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                            }
                            else if (Time[0] == "Sunday")
                            {
                                if (Time[1] == "8:00")
                                {
                                    SU810.IsEnabled = true;
                                    SU810.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "10:00")
                                {
                                    SU1012.IsEnabled = true;
                                    SU1012.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "14:00")
                                {
                                    SU1416.IsEnabled = true;
                                    SU1416.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "16:00")
                                {
                                    SU1618.IsEnabled = true;
                                    SU1618.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                            }
                            else if (Time[0] == "Monday")
                            {
                                if (Time[1] == "8:00")
                                {
                                    M810.IsEnabled = true;
                                    M810.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "10:00")
                                {
                                    M1012.IsEnabled = true;
                                    M1012.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "14:00")
                                {
                                    M1416.IsEnabled = true;
                                    M1416.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "16:00")
                                {
                                    M1618.IsEnabled = true;
                                    M1618.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                            }
                            else if (Time[0] == "Tuesday")
                            {
                                if (Time[1] == "8:00")
                                {
                                    T810.IsEnabled = true;
                                    T810.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "10:00")
                                {
                                    T1012.IsEnabled = true;
                                    T1012.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "14:00")
                                {
                                    T1416.IsEnabled = true;
                                    T1416.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "16:00")
                                {
                                    T1618.IsEnabled = true;
                                    T1618.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                            }
                            else if (Time[0] == "Wednesday")
                            {
                                if (Time[1] == "8:00")
                                {
                                    W810.IsEnabled = true;
                                    W810.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "10:00")
                                {
                                    W1012.IsEnabled = true;
                                    W1012.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "14:00")
                                {
                                    W1416.IsEnabled = true;
                                    W1416.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                                else if (Time[1] == "16:00")
                                {
                                    W1618.IsEnabled = true;
                                    W1618.Content = lessons[i].Name + "-" + lessons[i].Teacher[0] + " " + lessons[i].Teacher[1];
                                }
                            }
                        }
                    }
                   
                    
                }
            }
        }

        private void HomeWork_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("LessonForHomeWork.txt", ((Button)sender).Content.ToString());
            StudentHomeWork studentHomeWork = new();
            studentHomeWork.Show();
            
        }
    }
}
