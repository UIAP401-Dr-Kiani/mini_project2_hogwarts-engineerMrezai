using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Documents;

namespace hogward;

public class Professor : AuthorizePersons
{
    public string time { get; set; }
    public List<Lesson> lessens { get; set; }
    public bool SimultaneousTeaching { get; set; }
}