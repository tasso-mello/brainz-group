using domain.brainz.group.Base;

namespace domain.brainz.group.Entities;

public sealed class Student: BaseEntity
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    
    public string GraphId { get; private set; }
    
    public ICollection<Event> Events { get; private set; }
    
    private Student() { }

    public Student(string name, string email, string graphId)
    {
        Name = name;
        Email = email;
        GraphId = graphId;
        Events = new List<Event>();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}
