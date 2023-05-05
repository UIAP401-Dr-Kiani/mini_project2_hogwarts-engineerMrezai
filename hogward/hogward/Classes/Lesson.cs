using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;

public class Lesson
{
    public string[] Time { get; set; } = new string[2];
    public int NumberOfStudents { get; set; }
    public int Capacity = 50;
    public int PresentationSemester { get; set; }
    public string Name { get; set; }
}


//class Chemistry : Lesson
//{
//    Chemistry()
//    {
//        Name = "Chemistry";
//        PresentationSemester = 1;
//        try
//        {
//            string[] Chemicals = (File.ReadAllText("Chemistry/Chemicals.txt").Split("-"));
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No Chemicals.txt"));
//        }
//    }
//}


//class BotanicalOne : Lesson
//{
//    BotanicalOne()
//    {
//        PresentationSemester = 1;
//        Name = "BotanicalOne";
        
//        try
//        {
//            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No Plant for BotanicalOne"));
//        }
//    }

//}

//class BotanicalTwo : Lesson
//{
//    BotanicalTwo()
//    {
//        PresentationSemester = 2;
//        Name = "BotanicalTwo";
//        try
//        {
//            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No No Plant for BotanicalTwo"));
//        }
//    }
//}

//class BotanicalThree : Lesson
//{
//    BotanicalThree()
//    {
//        PresentationSemester = 3;
//        Name = "BotanicalThree";
//        try
//        {
//            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No Plant for BotanicalThree"));
//        }
//    }
//}

//class BotanicalFour : Lesson
//{
//    BotanicalFour()
//    {
//        PresentationSemester = 4;
//        Name = "BotanicalFour";
//        try
//        {
//            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No Plant for BotanicalFour"));
//        }
//    }
//}

//class Occultism : Lesson
//{
//    Occultism()
//    {
//        PresentationSemester = 2;
//        Name = "Occultism";
//        try
//        {
//            string[] Words = File.ReadAllText("Occultism/Words.txt").Split('-');
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No Word"));
//        }
//    }
//}


//class Sport : Lesson
//{
//    Sport()
//    {
//        PresentationSemester = 3;
//        try
//        {
//            Name = "Sport";
//            string[] TypeOfSport = File.ReadAllText("Sport/TypeOfSport.txt").Split('-');
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No sport"));
//        }
//    }
//}


//class Plant : Lesson
//{

//    Plant()
//    {
//        PresentationSemester = 4;
//        try
//        {
//            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
//        }
//        catch
//        {
//            throw new System.NullReferenceException(string.Format("No Plant"));
//        }
//    }
//}