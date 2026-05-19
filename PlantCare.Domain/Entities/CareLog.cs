namespace PlantCare.Domain.Entities;

public class CareLog
{
    public Guid Id { get; set; }
    public Guid PlantId { get; set; }
    public CareType CareType { get; set; }
    public DateTime PerformedAt { get; set; }
    public string? Notes { get; set; }

    public Plant Plant { get; set; } = null!;
}
