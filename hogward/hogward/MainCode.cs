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

class program
{
    public static List<AuthorizePersons> AuthorizePersonsDetecter()
        {
            dynamic jsonFormFile = JsonConvert.DeserializeObject<List<AuthorizePersons>>(File.ReadAllText("JSON_DATA.json"));
            return jsonFormFile;
        }
    public static int LoginCheck(string Type ,string UserName,string Password)
    {
        List<AuthorizePersons> authorizePersons = program.AuthorizePersonsDetecter();
        for (int i = 0; i < authorizePersons.Count; i++)
        {
            if (authorizePersons[i].role == Type)
            {
                if (UserName == authorizePersons[i].username && Password == authorizePersons[i].password)
                {
                    return 1;
                }
            }
        }
        throw new System.Exception();
        return 0;
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