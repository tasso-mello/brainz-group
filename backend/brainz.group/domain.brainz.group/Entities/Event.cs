using domain.brainz.group.Base;

namespace domain.brainz.group.Entities;

public sealed class Event : BaseEntity
{
    public string GraphId { get; private set; }
    public string Subject { get; private set; }
    public string? Description { get; private set; }
    public DateTime StartAt { get; private set; }
    public DateTime EndAt { get; private set; }
    public string? Location { get; private set; }
    public Guid StudentId { get; private set; }
    public Student Student { get; private set; }

    private Event()
    {
    }

    public Event(string graphId, string subject, DateTime startAt, DateTime endAt, Guid studentId,
        string? description = null, string? location = null)
    {
        GraphId = graphId;
        Subject = subject;
        Description = description;
        StartAt = startAt;
        EndAt = endAt;
        Location = location;
        StudentId = studentId;

        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
}