namespace hogward;

public class Student : AuthorizePersons
{
    public string[] PassedUnits { get; set; }
    public string[] plant { get; set; } = new string[8];
    public int Term { get; set; } = 1;
    public string HostelNumber { get; set; }
    public bool IsInHogward { get; set; } = false;
}