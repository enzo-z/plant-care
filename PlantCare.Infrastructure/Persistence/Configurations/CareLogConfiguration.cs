using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlantCare.Domain.Entities;

namespace PlantCare.Infrastructure.Persistence.Configurations;

public class CareLogConfiguration : IEntityTypeConfiguration<CareLog>
{
    public void Configure(EntityTypeBuilder<CareLog> builder)
    {
        builder.ToTable("CareLogs");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever();

        builder.Property(c => c.CareType)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(c => c.PerformedAt)
            .IsRequired()
            .HasConversion(
                v => v,
                v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

        builder.Property(c => c.Notes)
            .HasMaxLength(500);

        builder.HasOne(c => c.Plant)
            .WithMany(p => p.CareLogs)
            .HasForeignKey(c => c.PlantId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
