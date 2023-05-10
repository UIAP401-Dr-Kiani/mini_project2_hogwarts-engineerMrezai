using hogward;
using hogward.Windows;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            Lesson Lesson1 = new Lesson();
            Lesson1.Name = lessons1[0];
            Lesson1.Time[0] = lessons1[1];
            Lesson1.Time[1] = lessons1[2];
            profesors[i].lessens[0] = Lesson1;
            Lesson1.Teacher[0] = profesors[i].Name;
            Lesson1.Teacher[1] = profesors[i].Family;


            Lesson Lesson2 = new Lesson();
            Lesson2.Name = lessons2[0];
            Lesson2.Time[0] = lessons2[1];
            Lesson2.Time[1] = lessons2[2];
            profesors[i].lessens[1] = (Lesson2);
            Lesson2.Teacher[0] = profesors[i].Name;
            Lesson2.Teacher[1] = profesors[i].Family;

            Lesson Lesson3 = new Lesson();
            Lesson3.Name = lessons3[0];
            Lesson3.Time[0] = lessons3[1];
            Lesson3.Time[1] = lessons3[2];
            profesors[i].lessens[2] = (Lesson3);
            Lesson3.Teacher[0] = profesors[i].Name;
            Lesson3.Teacher[1] = profesors[i].Family;


            File.WriteAllText("Professors.json", JsonConvert.SerializeObject(profesors));
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
    public static string[] UserFounder()
    {
        string count = "-1";
        string[] text = new string[3];
        var students = Program.StudentDetecter();
        string[] userindex = File.ReadAllText("UserIndex.txt").Split(" ");
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
        var professors = ProfessorDetecter();
        List<string> AllowProfessor = new();
        for (int i = 0; i < professors.Length; i++)
        {
            if (professors[i].lessens[0] == null)
            {
                continue;
            }
            else if (professors[i].lessens[0].Name == name)
            {
                string lesson = professors[i].Name + " " + professors[i].Family + " " + professors[i].lessens[0].Time[0] + " " + professors[i].lessens[0].Time[1];
                AllowProfessor.Add(lesson);
            }
            else if (professors[i].lessens[1].Name == name)
            {
                string lesson = professors[i].Name + " " + professors[i].Family + " " + professors[i].lessens[1].Time[0] + " " + professors[i].lessens[1].Time[1];
                AllowProfessor.Add(lesson);
            }
            else if (professors[i].lessens[2].Name == name)
            {
                string lesson = professors[i].Name + " " + professors[i].Family + " " + professors[i].lessens[2].Time[0] + " " + professors[i].lessens[2].Time[1];
                AllowProfessor.Add(lesson);
            }

        }
        return AllowProfessor;
    }
    //Professor lesson finder
    public static List<string> ProfessorLessonFinder()
    {
        List<string> LESSONS = new List<string>();
        Error_page error_Page = new Error_page();
        var professors = ProfessorDetecter();
        var index = File.ReadAllText("UserIndex.txt").Split(" ");
        for (int i = 0;i<professors.Length;i++)
        {
            if (professors[i].Username == index[0] && professors[i].Password == index[1])
            {
                if (professors[i].lessens[0] != null)
                {
                    for(int j = 0; j < professors[i].lessens.Length;j++)
                    {
                        LESSONS.Add(professors[i].lessens[j].Name + " " + professors[i].lessens[j].Time[0] + " " + professors[i].lessens[j].Time[1]);
                    }
                    return LESSONS;
                }
            }
        }
        File.WriteAllText("Error.txt", "You have not selected any course");
        error_Page.Show();
        return null;
    }
    //HomeWork Writer For Teacher
    public static void ProfessorHomeWorkWriter(string DeadLine, string Lesson, string Title , int Point)
    {
        var professors = ProfessorDetecter();
        var index = File.ReadAllText("UserIndex.txt").Split(" ");
        
        for (int i = 0; i < professors.Length; i++)
        {
            if (professors[i].Username == index[0] && professors[i].Password == index[1])
            {
                for (int j = 0; j < professors[i].lessens.Length;j++)
                {
                    

                    if ((professors[i].lessens[j].Name + " " + professors[i].lessens[j].Time[0] + " " + professors[i].lessens[j].Time[1]) == Lesson)
                    {
                        professors[i].lessens[j].homework = new();
                        professors[i].lessens[j].homework.Title = Title;
                        professors[i].lessens[j].homework.DeadLine = DeadLine;
                        professors[i].lessens[j].homework.Point = Point;
                        break;
                    }
                }
                break;
            }
        }
        File.WriteAllText("Professors.json", JsonConvert.SerializeObject(professors));

        File.WriteAllText("Error.txt", "HomeWork added sucsessfully");

        Error_page error_Page = new Error_page();
        error_Page.Show();
    }
}