using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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
            var students = Program.StudentDetecter();
            int Hour = Convert.ToInt16(DateTime.Now.ToString("HH")) * 60;
            int Min = Convert.ToInt16(DateTime.Now.ToString("mm"));
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].TrainNum == 0 && Hour + Min >=8*60)
                {
                    students[i].TrainNum = -1;
                    students[i].IsInHogward = true;
                    File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                }
                else if (students[i].TrainNum == 1 && Hour + Min >= 12*60)
                {
                    students[i].TrainNum = -1;
                    students[i].IsInHogward = true;
                    File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                }
                else if (students[i].TrainNum ==2 && Hour + Min >=16*60)
                {
                    students[i].TrainNum = -1;
                    students[i].IsInHogward = true;
                    File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                }
                else if (students[i].TrainNum == 3 && Hour + Min >=20*60)
                {
                    students[i].TrainNum = -1;
                    students[i].IsInHogward = true;
                    File.WriteAllText("Error.txt", "Wellcome to the Hogward");
                }
            }
            
        }

        public static int TrainCheack()
        {
            int count = 0;
            string[] index = File.ReadAllText("UserIndex.txt").Split(" ");
            var students = Program.StudentDetecter();
            for(int i = 0; i< students.Length;i++)
            {
                if (students[i].Username == index[0] && students[i].Password == index[1])
                {
                    if (students[i].IsInHogward == true)
                    {
                        return 0;
                    }
                    else
                        return 1;
                }
            }
            return -1;
        }
    }
}
