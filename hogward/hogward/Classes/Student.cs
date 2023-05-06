namespace hogward;

public class Student : AuthorizePersons
{
    public string[] PassedUnits { get; set; }
    public int Term { get; set; } = 1;
    public string HostelNumber { get; set; }
}