using System;

enum Gender
{
    Man, Woman, etc
}
enum BreedType
{
    HalfBlood, PureBlood, MuggleBlood
}
enum Roles
{
    teacher, student
}


static struct human
{
    string Name;
    string Family;
    string BirthDay;
    Gender gender;
    string Father;
    string UserName;
    string Password;
    BreedType breedType;
}

public class MainCode
{
	public MainCode()
	{
        /*using (StreamReader file = new StreamReader("file.tsv"))
        {
            string ln;

            while ((ln = file.ReadLine()) != null)
            {
                string[] human = ln.Split("\t").ToArray<string>();
                
                human[0] = name
                human[1] = family
                human[2] = dataOfBirth
                human[3] = gender
                human[4] = father
                human[5] = username
                human[6] = password
                human[7] = race type
                human[8] = role
                
            }
            file.Close();
        }*/
    }

}

class AuthorizePersons : human
{
    static struct authorizepersons
	{
		string Room;
		string Curriculum;
		Pets pet;
		string Group;
		bool Baggage;
		Roles role;
		string massage;
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
        sting[] time;
        string[] lessens;
		bool SimultaneousTeaching;
    }
}


class Dumbledore : AuthorizePersons // after creating Hostels
{
    struct Ticket
    {
        string Time;
        string CabinNumber;
        string ChairNumber;
    }
    public string Massage(Ticket ticket)
    {
        return ("haggard accept you. We are waiting for you."+ ticket.Time + ticket.CabinNumber + ticket.ChairNumber)
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
		list<string> Users;
		list<string> Quidditch;

    }
}

struct lesson
{
    string Time;
    int NumberOfStudents;
    int Capacity;
    string PresentationSemester;
    string Name;
}


class Chemistry : lesson
{
	list<string> chemicals;
}


class Botanical : lesson
{
	list<string> Semester1Plants;
    list<string> Semester2Plants;
    list<string> Semester3Plants;
    list<string> Semester4Plants;
}


class Occultism : lesson
{
	list<string> Words;
}


class Sport :lesson
{
	string TypeOfSport;
}


class Plant : lesson
{
	string Name;
	int Count;
}


static struct Dorm
{
	string Group;
	int Floor = 4;
	int Room = 5;
	int Bed = 3;
	Gender gender;
	static code
}