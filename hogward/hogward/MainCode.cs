using hogward;
using hogward.Windows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Animation;

class Program
{
    //AuthorizePersonsDetecter
    public static AuthorizePersons[] AuthorizePersonsDetecter()
    {
        return JsonConvert.DeserializeObject<AuthorizePersons[]>(File.ReadAllText("JSON_DATA.json"));
    }
    //ProfessorDetecter
    public static Professor[] ProfessorDetecter()
    {
        return JsonConvert.DeserializeObject<Professor[]>(File.ReadAllText("Professors.json"));
    }
    //StudentDetecter
    public static Student[] StudentDetecter()
    {
        return JsonConvert.DeserializeObject<Student[]>(File.ReadAllText("Students.json"));
    }
    //lessonDetecter
    public static Lesson[] LessonDetecter()
    {
        return JsonConvert.DeserializeObject<Lesson[]>(File.ReadAllText("Lessons.json"));
    }
    //lessonSelectedDetecter
    public static Lesson[] lessonSelectedDetecter()
    {
        return JsonConvert.DeserializeObject<Lesson[]>(File.ReadAllText("LessonSelected.json"));
    }
    //login page
    public static int LoginCheck(string Type, string UserName, string Password)
    {
        AuthorizePersons[] authorizePersons = Program.AuthorizePersonsDetecter();
        for (int i = 0; i < authorizePersons.Length; i++)
        {
            if (authorizePersons[i].role == Type)
            {
                if (UserName == authorizePersons[i].Username && Password == authorizePersons[i].Password)
                {
                    Writer(UserName, Password);
                    return 1;
                }
            }
        }
        return -1;
    }
    //Professor Class selector and Writer
    public static void ProfessorSelector(string lesson1, string lesson2, string lesson3, int i)
    {

        Professor[] profesors = ProfessorDetecter();
        string[] lessons1 = lesson1.Split(' '), lessons2 = lesson2.Split(' '), lessons3 = lesson3.Split(' ');

        if (lesson1 != lesson2 && lesson2 != lesson3 && lesson3 != lesson1)
        {
            List<Lesson> lessons = new();
            Lesson Lesson1 = new();
            Lesson1.Name = lessons1[0];
            Lesson1.Time[0] = lessons1[1];
            Lesson1.Time[1] = lessons1[2];
            Lesson1.Teacher[0] = profesors[i].Name;
            Lesson1.Teacher[1] = profesors[i].Family;

            lessons.Add(Lesson1 );

            Lesson Lesson2 = new Lesson();
            Lesson2.Name = lessons2[0];
            Lesson2.Time[0] = lessons2[1];
            Lesson2.Time[1] = lessons2[2];
            Lesson2.Teacher[0] = profesors[i].Name;
            Lesson2.Teacher[1] = profesors[i].Family;

            lessons.Add(Lesson2 );

            Lesson Lesson3 = new Lesson();
            Lesson3.Name = lessons3[0];
            Lesson3.Time[0] = lessons3[1];
            Lesson3.Time[1] = lessons3[2];
            Lesson3.Teacher[0] = profesors[i].Name;
            Lesson3.Teacher[1] = profesors[i].Family;

            lessons.Add(Lesson3);

            File.WriteAllText("LessonSelected.json",JsonConvert.SerializeObject(lessons));
            using (var writer = new StreamWriter("Error.txt"))
                writer.WriteLine("Lessons Saved sucssesfully");
            throw new System.Exception();
        }
        else
        {
            using (var writer = new StreamWriter("Error.txt"))
                writer.WriteLine("Same lesson choise in same date and same time");
            throw new Exception();
        }
    }
    //userfounder
    public static string[] UserFounder(string role)
    {
        string count = "-1";
        string[] text = new string[3];
        var students = Program.StudentDetecter();
        var teachers = ProfessorDetecter();
        string[] userindex = File.ReadAllText("UserIndex.txt").Split(" ");
        if (role == "teacher")
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (teachers[i].Username == userindex[0] && teachers[i].Password == userindex[1])
                {
                    text[0] = teachers[i].Name;
                    text[1] = teachers[i].Family;
                    text[2] = Convert.ToString(i);
                    break;
                }
                
            }
            return text;
        }
        else if (role == "student")
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Username == userindex[0] && students[i].Password == userindex[1])
                {
                    text[0] = students[i].Name;
                    text[1] = students[i].Family;
                    text[2] = Convert.ToString(i);
                    break;
                }
                
            }
            return text;
        }
        else
            return text;
    }
    //UserrWriter
    public static void Writer(string username, string password)
    {
        using (var writer = new StreamWriter("UserIndex.txt"))
        {
            writer.Write(username + " " + password);
        }
    }
    //professor finder for StudentLessonSelction
    public static List<string> AllowProfesorLesson(string name)
    {
        var lessons = lessonSelectedDetecter();
        List<string> AllowProfessor = new();
        for (int i = 0; i < lessons.Length; i++)
        {
            if (lessons[i].Name == name)
            {
                string lesson = lessons[i].Teacher[0] + " " + lessons[i].Teacher[1] + " " + lessons[i].Time[0] + " " + lessons[i].Time[1];
                AllowProfessor.Add(lesson);
            }
        }
        return AllowProfessor;
    }
    //Professor lesson finder
    public static List<string> ProfessorLessonFinder()
    {
        var lessons = lessonSelectedDetecter();
        List<string> LESSONS = new List<string>();
        Error_page error_Page = new Error_page();
        var professors = ProfessorDetecter();
        var detail = UserFounder("teacher");
        int index = Convert.ToInt32(detail[2]);
        for (int i = 0; i < lessons.Length; i++)
        {
            if (lessons[i].Teacher[0] == professors[index].Name && lessons[i].Teacher[1] == professors[index].Family)
            {
                LESSONS.Add(lessons[i].Name + " " + lessons[i].Time[0] + " " + lessons[i].Time[1]);
            }
        }
        return LESSONS;
        File.WriteAllText("Error.txt", "You have not selected any course");
        error_Page.Show();
        
    }
    //HomeWork Writer For Teacher
    public static void ProfessorHomeWorkWriter(string DeadLine, string Lesson, string Title, int Point)
    {
        var professors = ProfessorDetecter();
        var detaile = UserFounder("teacher");
        var Lessons = lessonSelectedDetecter();
        int index =Convert.ToInt16( detaile[2]);
        for (int i = 0; i < Lessons.Length; i++)
        {
            if ((Lessons[i].Name + " " + Lessons[i].Time[0] + " " + Lessons[i].Time[1]) == Lesson)
            {
                Lessons[i].homework = new();
                Lessons[i].homework.Title = Title;
                Lessons[i].homework.DeadLine = DeadLine;
                Lessons[i].homework.Point = Point;
                File.WriteAllText("LessonSelected.json", JsonConvert.SerializeObject(Lessons));

                File.WriteAllText("Error.txt", "HomeWork added sucsessfully");

                Error_page error_Page = new Error_page();
                error_Page.Show();
                break;
            }
            
        }
        
    }
    //HomeWork Finder For Student
    //public static void StudentHomeWorkSeter()
    //{
    //    int count = -1;
    //    List<string> Lessons = new List<string>();
    //    var index = File.ReadAllText("UserIndex.txt").Split(" ");
    //    var students = StudentDetecter();
    //    for (int i = 0; i < students.Length; i++)
    //    {
    //        if (students[i].Username == index[0] && students[i].Password == index[1])
    //        {
    //            count = i; break;
    //        }
    //    }
    //    var professors = ProfessorDetecter();
    //    for (int i = 0; i < professors.Length; i++)
    //    {
    //        for (int j = 0; j < professors[i].lessens.Length; j++)
    //        {
    //            if (professors[i].lessens[j] == null)
    //                continue;
    //            for (int k = 0; k < students[count].lessens.Length; k++)
    //            {
    //                if (students[count].lessens[k] == null)
    //                    continue;
    //                if (professors[i].lessens[j].Name == students[count].lessens[k].Name && students[count].lessens[k].Teacher[0] == professors[i].lessens[j].Teacher[k] && students[count].lessens[k].Teacher[0] == professors[i].lessens[j].Teacher[0] && students[count].lessens[k].Time[0] == professors[i].lessens[j].Time[0] && students[count].lessens[k].Time[1] == professors[i].lessens[j].Time[1])
    //                {
    //                    if (professors[i].lessens[j].homework == null)
    //                        continue;
    //                    students[count].lessens[k].homework.Title = professors[i].lessens[j].homework.Title;
    //                    students[count].lessens[k].homework.DeadLine = professors[i].lessens[j].homework.DeadLine;
    //                    students[count].lessens[k].homework.Point = professors[i].lessens[j].homework.Point;
    //                }
    //            }
    //        }
    //    }
    //    File.WriteAllText("Students.json", JsonConvert.SerializeObject(students));
    //}
    //student Lesson name returner
    public static List<string> StudentLessonReturner()
    {
        var students = StudentDetecter();
        var lessons = lessonSelectedDetecter();
        string Lesson;
        string[] detail = UserFounder("student");
        int index = Convert.ToInt32(detail[2]);
        List<string> LESSONS = new List<string>();
        for (int i = 0; i < lessons.Length; i++)
        {
            for (int j = 0; j < lessons[i].Students.Count;j++)
            {
                if (lessons[i].Students[j].Username == students[index].Username && lessons[i].Students[j].Password == students[index].Password)
                {
                    Lesson = lessons[i].Name + " " + lessons[i].Teacher[0] + lessons[i].Teacher[1];
                    LESSONS.Add(Lesson);
                }
            }
        }
        return LESSONS;
    }
}