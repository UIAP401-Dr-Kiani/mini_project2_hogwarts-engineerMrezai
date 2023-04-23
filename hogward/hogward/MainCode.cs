using hogward;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;

class program
{
    //    public static void  StudentDetecter()
    //    { 
    //        {
    //            List<string> Teachaer = new List<string[]>();
    //            List<string[]> Student = new List<string[]>();
    //            AuthorizePersons[] authorizePersons; 
    //            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
    //            {
    //                string ln;
    //                while ((ln = file.ReadLine()) != null)
    //                {
    //                    string[] human = ln.Split("\t").ToArray<string>(); 
    //                    if (human[8] == "teacher")
    //                    {
    //                        Teachaer.Add(human);
    //                    }
    //                    else if (human[8] == "student") 
    //                    {
    //                        Student.Add(human);
    //                    }
    //                }
    //                file.Close();
    //            }
    //        }
    //    }
    //}


    public static void StudentDetecter()
    {
        List<AuthorizePersons> source = new List<AuthorizePersons>();

        using (StreamReader r = new StreamReader("JSON_DATA.json"))
        {
            string json = r.ReadToEnd();
            source = JsonSerializer.Deserialize<List<AuthorizePersons>>(json);
        }
    }
}

class Drom
{
    struct dorm
    {
        string Group;
        static int Floor = 4;
        static int Room = 5;
        static int Bed = 3;
        Gender gender;
    }
}