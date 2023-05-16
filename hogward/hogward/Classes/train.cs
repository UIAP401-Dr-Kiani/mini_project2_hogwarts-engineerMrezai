using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using hogward.Windows;
using Newtonsoft.Json;

namespace hogward.Classes
{
    public class train
    {
        public static string[] Train()
        {
            string[] result = new string[2];
            int min = 5 * 60;
            int count = -1;
            int[,] DepartureTime = new int[4, 2];
            DepartureTime[0, 0] = 08;
            DepartureTime[0, 1] = 00;
            DepartureTime[1, 0] = 12;
            DepartureTime[1, 1] = 00;
            DepartureTime[2, 0] = 16;
            DepartureTime[2, 1] = 00;
            DepartureTime[3, 0] = 20;
            DepartureTime[3, 1] = 00;
            DateTime dt = DateTime.Now;
            int TimeHour = Convert.ToInt16(dt.ToString("HH"));
            int TimeMin = Convert.ToInt16(dt.ToString("mm"));
            int RHour = 0, RMin = 0;
            for (int i = 0; i < 4; i++)
            {
                if (TimeHour * 60 + TimeMin > 20 * 60)
                {
                    result[0] = "Next Tomarow 8:00";
                    result[1] = "-1";
                    return result;

                }
                if (DepartureTime[i, 0] > TimeHour)
                {
                    if (DepartureTime[i, 1] < TimeMin)
                    {
                        RMin = 60 - TimeMin;
                        RHour = DepartureTime[i, 0] - TimeHour - 1;
                    }
                    else
                    {
                        RHour = DepartureTime[i, 0] - TimeHour;
                    }
                }
                else
                    continue;
                if (RMin + RHour * 60 < min)
                {
                    min = RMin + RHour * 60;
                    count = i;
                }
            }
            result[0] = Convert.ToString(min);
            result[1] = Convert.ToString(count);
            return result;
        }


        public static void TravelTrain()
        {
            Error_page error_Page = new();
            var students = Program.StudentDetecter();
            int Hour = Convert.ToInt16(DateTime.Now.ToString("HH")) * 60;
            int Min = Convert.ToInt16(DateTime.Now.ToString("mm"));
            var detail = Program.UserFounder("student");
            int index = Convert.ToInt32(detail[2]);
            if (students[index].TrainNum == 0 && Hour + Min >= 8 * 60)
            {
                students[index].TrainNum = -1;
                students[index].IsInHogward = true;
                File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                error_Page.Show();
            }
            else if (students[index].TrainNum == 1 && Hour + Min >= 12 * 60)
            {
                students[index].TrainNum = -1;
                students[index].IsInHogward = true;
                File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                error_Page.Show();
            }
            else if (students[index].TrainNum == 2 && Hour + Min >= 16 * 60)
            {
                students[index].TrainNum = -1;
                students[index].IsInHogward = true;
                File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                error_Page.Show();
            }
            else if (students[index].TrainNum == 3 && Hour + Min >= 20 * 60)
            {
                students[index].TrainNum = -1;
                students[index].IsInHogward = true;
                File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                error_Page.Show();
            }

            File.WriteAllText("Students.json", JsonConvert.SerializeObject(students));
            
        }

        public static int TrainCheack()
        {
            int count = 0;
            var students = Program.StudentDetecter();
            var detail = Program.UserFounder("student");
            int index = Convert.ToInt32(detail[2]);
            if (students[index].IsInHogward == true)
            {
                return 0;
            }
            else
                return 1;
        }
    }
}
