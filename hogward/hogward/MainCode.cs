using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Documents;
using hogward;

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