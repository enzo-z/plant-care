using Microsoft.EntityFrameworkCore;
using PlantCare.Domain.Entities;
using PlantCare.Infrastructure.Persistence.Configurations;

namespace PlantCare.Infrastructure.Persistence;

public class PlantCareDbContext(DbContextOptions<PlantCareDbContext> options) : DbContext(options)
{
    public DbSet<Plant> Plants => Set<Plant>();
    public DbSet<CareLog> CareLogs => Set<CareLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PlantConfiguration());
        modelBuilder.ApplyConfiguration(new CareLogConfiguration());
    }
}
