using domain.brainz.group.Base;
using domain.brainz.group.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace data.brainz.group.Configurations;

public sealed class StudentConfiguration : BaseEntityConfiguration<Student>
{
    public new void Configure(EntityTypeBuilder<Student> builder)
    {
        base.Configure(builder);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(s => s.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(s => s.GraphId)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasMany(s => s.Events)
            .WithOne(e => e.Student)
            .HasForeignKey(e => e.StudentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}