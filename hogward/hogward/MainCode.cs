using System;
using System.Collections.Generic;
using System.Windows.Documents;

public enum Gender
{
    Man, Woman, etc
}
public enum BreedType
{
    HalfBlood, PureBlood, MuggleBlood
}
public enum Roles
{
    teacher, student
}
public enum Pets
{
    l,rat,cat
}



class Human
{
    struct humans
    {
        static public string Name;
        static public string Family;
        static public string BirthDay;
        static public Gender gender;
        static public string Father;
        static public string UserName;
        static public string Password;
        static public BreedType breedType;
    }
}

class AuthorizePersons : Human
{
    struct authorizepersons
	{
		static public string Room ;
        static public string Curriculum;
        static public Pets pet;
        static public string Group;
        static public bool Baggage;
        static public Roles role;
        static public string Massage;
    }
}


class Student : AuthorizePersons
{
	struct student
	{
		string PassedUnits;
		string Term;
		string HostelNumber;
    }
}


class Professor : AuthorizePersons
{
	struct professor
	{
        string[] time;
        string[] lessens;
		bool SimultaneousTeaching;
    }
}


class Dumbledore : AuthorizePersons // after creating Hostels
{
    public string Massage(string Time, string CabinNumber, string ChairNumber)
    {
        return ("haggard accept you. We are waiting for you." + Time + CabinNumber + ChairNumber);
    }
}


class Group
{
	enum Type
	{
        Hufflepuff, Gryffindor, Ravenclaw, Slytherin
    }
	
	struct group
	{
		Type type;
		int Score;
		List <string> Users;
		List <string> Quidditch;

    }
}

class Lesson
{
    struct lesson
    {
        string Time;
        int NumberOfStudents;
        int Capacity;
        string PresentationSemester;
        string Name;
    }
}

class Chemistry : Lesson
{
	List<string> chemicals = new List<string>();
}


class Botanical : Lesson
{
	List<string> Semester1Plants;
    List<string> Semester2Plants;
    List<string> Semester3Plants;
    List<string> Semester4Plants;
}


class Occultism : Lesson
{
	List<string> Words;
}


class Sport :Lesson
{
	string TypeOfSport;
}


class Plant : Lesson
{
	string Name;
	int Count;
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