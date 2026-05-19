namespace PlantCare.Domain.Entities;

public class Plant
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Species { get; set; }
    public string? Location { get; set; }
    public int WateringIntervalDays { get; set; }
    public DateTime? LastWateredAt { get; set; }
    public DateTime? LastFertilizedAt { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<CareLog> CareLogs { get; set; } = [];
}
