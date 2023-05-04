using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace hogward;

public class Lesson
{
    protected string Time { get; set; } = "0:00 , 0:00";
    protected int NumberOfStudents { get; set; }
    protected int Capacity = 50;
    protected int PresentationSemester { get; set; }
    protected string Name { get; set; } = "not set";
}


class Chemistry : Lesson
{
    Chemistry()
    {
        Name = "Chemistry";
        PresentationSemester = 1;
        try
        {
            string[] Chemicals = (File.ReadAllText("Chemistry/Chemicals.txt").Split("-"));
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No Chemicals.txt"));
        }
    }
}


class BotanicalOne : Lesson
{
    BotanicalOne()
    {
        PresentationSemester = 1;
        Name = "BotanicalOne";
        
        try
        {
            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No Plant for BotanicalOne"));
        }
    }

}

class BotanicalTwo : Lesson
{
    BotanicalTwo()
    {
        PresentationSemester = 2;
        Name = "BotanicalTwo";
        try
        {
            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No No Plant for BotanicalTwo"));
        }
    }
}

class BotanicalThree : Lesson
{
    BotanicalThree()
    {
        PresentationSemester = 3;
        Name = "BotanicalThree";
        try
        {
            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No Plant for BotanicalThree"));
        }
    }
}

class BotanicalFour : Lesson
{
    BotanicalFour()
    {
        PresentationSemester = 4;
        Name = "BotanicalFour";
        try
        {
            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No Plant for BotanicalFour"));
        }
    }
}

class Occultism : Lesson
{
    Occultism()
    {
        PresentationSemester = 2;
        Name = "Occultism";
        try
        {
            string[] Words = File.ReadAllText("Occultism/Words.txt").Split('-');
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No Word"));
        }
    }
}


class Sport : Lesson
{
    Sport()
    {
        PresentationSemester = 3;
        try
        {
            Name = "Sport";
            string[] TypeOfSport = File.ReadAllText("Sport/TypeOfSport.txt").Split('-');
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No sport"));
        }
    }
}


class Plant : Lesson
{

    Plant()
    {
        PresentationSemester = 4;
        try
        {
            string[] Chemicals = File.ReadAllText("Botanical/Planet.txt").Split("-");
        }
        catch
        {
            throw new System.NullReferenceException(string.Format("No Plant"));
        }
    }
}