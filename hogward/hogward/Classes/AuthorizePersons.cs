using System.Windows.Documents;
using System.Windows.Forms.Layout;

namespace hogward;

public class AuthorizePersons : Human
{
    public string room { get; set; }
    public string curriculum { get; set; }
    public string group { get; set; }
    public string[] massage { get; set; } = new string[100];
    public string pet { get; set; }
    public bool baggage { get; set; } = false;
    public string role { get; set; }
}