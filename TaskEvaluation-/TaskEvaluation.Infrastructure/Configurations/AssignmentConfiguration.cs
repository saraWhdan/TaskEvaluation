using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Infrastructure.Configurations
{
	public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).IsRequired();

            builder.HasMany(a => a.Solutions)
              .WithOne(s => s.Assignment)
              .HasForeignKey(s => s.AssignmentId)
              .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(a => a.Group)
                   .WithMany(g => g.Assignments)
                   .HasForeignKey(a => a.GroupId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
