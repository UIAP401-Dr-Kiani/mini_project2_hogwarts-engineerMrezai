namespace hogward;

public class AuthorizePersons : Human
{
    protected string Room { get; set; }
    protected string Curriculum { get; set; }
    protected string Group { get; set; }
    protected string Massage { get; set; }

    protected Pets pet { get; set; }
    protected bool Baggage { get; set; }
    protected Roles role { get; set; }
}