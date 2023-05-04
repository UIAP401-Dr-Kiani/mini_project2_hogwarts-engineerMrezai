using hogward;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.RightsManagement;
using hogward.Windows;

class Program
{

    public static int index { get; set; }

    //Detecter
    public static AuthorizePersons[] AuthorizePersonsDetecter(string role)
    {
        if (role == "teacher")
            return JsonConvert.DeserializeObject<Professor[]>(File.ReadAllText("Professors.json"));
        else if (role == "student")
            return JsonConvert.DeserializeObject<AuthorizePersons[]>(File.ReadAllText("Students.json"));
        else
            return JsonConvert.DeserializeObject<AuthorizePersons[]>(File.ReadAllText("JSON_DATA.json"));
    }


    //login page
    public static int LoginCheck(string Type, string UserName, string Password)
    {
        AuthorizePersons[] authorizePersons = Program.AuthorizePersonsDetecter("list");
        for (int i = 0; i < authorizePersons.Length; i++)
        {
            if (authorizePersons[i].role == Type)
            {
                if (UserName == authorizePersons[i].Username && Password == authorizePersons[i].Password)
                {
                    Writer(UserName,Password);
                    return 1;
                }
            }
        }
        throw new System.Exception();
    }

    //Professor Class selector
    public static int ProfessorSelector(string lesson1, string lesson2, string lesson3)
    {
        AuthorizePersons[] authorizePersons = Program.AuthorizePersonsDetecter("teacher");
        if (lesson1 != lesson2 && lesson2 != lesson3 && lesson3 != lesson1)
        {
            return 1;
        }
        else
            throw new Exception();
    }


    //UserWriter
    public static void Writer(string username, string password)
    {
        using (var writer = new StreamWriter("UserIndex.txt"))
        {
            writer.Write(username + " " + password);
        }
    }
}