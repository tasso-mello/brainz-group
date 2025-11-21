using domain.brainz.group.Base;
using domain.brainz.group.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.brainz.group.Configurations;

public sealed class EventConfiguration : BaseEntityConfiguration<Event>
{
    public new void Configure(EntityTypeBuilder<Event> builder)
    {
        base.Configure(builder);

        builder.Property(e => e.GraphId)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Subject)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(e => e.Location)
            .HasMaxLength(200);

        builder.Property(e => e.Description)
            .HasMaxLength(1000);

        builder.Property(e => e.StartAt).IsRequired();
        builder.Property(e => e.EndAt).IsRequired();
    }
}