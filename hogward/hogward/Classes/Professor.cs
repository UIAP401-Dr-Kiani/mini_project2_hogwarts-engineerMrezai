using System.Collections.Generic;
using System.Dynamic;
using System.Windows.Documents;

namespace hogward;

public class Professor : AuthorizePersons
{
    public bool SimultaneousTeaching { get; set; }
}