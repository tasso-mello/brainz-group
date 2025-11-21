namespace domain.brainz.group.Base;

public abstract class BaseEntity
{
    public Guid Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }
    public DateTime UpdatedAt { get; protected set; }

    public void ToCreate()
    {
        CreatedAt = DateTime.UtcNow;
    }
    
    public void ToUpdate()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}
