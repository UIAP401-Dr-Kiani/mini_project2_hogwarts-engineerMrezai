using hogward;
using Newtonsoft.Json;
using System;
using System.IO;

class Program
{

    public static int index { get; set; }

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
        throw new System.Exception();
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
            profesors[i].lessens.Add(Lesson1);

            Lesson Lesson2 = new Lesson();
            Lesson2.Name = lessons2[0];
            Lesson2.Time[0] = lessons2[1];
            Lesson2.Time[1] = lessons2[2];
            profesors[i].lessens.Add(Lesson2);

            Lesson Lesson3 = new Lesson();
            Lesson3.Name = lessons3[0];
            Lesson3.Time[0] = lessons3[1];
            Lesson3.Time[1] = lessons3[2];
            profesors[i].lessens.Add(Lesson3);


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













    //UserfounderWriter
    public static void Writer(string username, string password)
    {
        using (var writer = new StreamWriter("UserIndex.txt"))
        {
            writer.Write(username + " " + password);
        }
    }
}