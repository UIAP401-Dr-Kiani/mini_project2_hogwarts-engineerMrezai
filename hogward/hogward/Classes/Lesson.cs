using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;

public class Lesson
{
    public string[] Teacher { get; set; } = new string[2];
    public string[] Time { get; set; } = new string[2];
    public int NumberOfStudents { get; set; }
    public int Capacity = 50;
    public int PresentationSemester { get; set; }
    public string Name { get; set; } = "";
}
 
