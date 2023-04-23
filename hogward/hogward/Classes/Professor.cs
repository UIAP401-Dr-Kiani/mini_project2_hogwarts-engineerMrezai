using System.Dynamic;

namespace hogward;

public class Professor : AuthorizePersons
{
    protected string time { get; set; }
    protected string lessens { get; set; } 
    protected bool SimultaneousTeaching { get; set; }
}