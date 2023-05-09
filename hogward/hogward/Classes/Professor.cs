using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Documents;

namespace hogward;

public class Professor : AuthorizePersons
{
    public Lesson[] lessens { get; set; }
    public bool SimultaneousTeaching { get; set; }
}