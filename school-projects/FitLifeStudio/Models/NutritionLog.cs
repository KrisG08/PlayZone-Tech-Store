using System.ComponentModel.DataAnnotations;

namespace FitLifeStudio.Models;

public sealed class NutritionLog
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public FitLifeUser User { get; set; } = null!;
    public DateTimeOffset LoggedAt { get; set; } = DateTimeOffset.UtcNow;

    [Range(0, 100000)] public decimal Calories { get; set; }
    [Range(0, 10000)] public decimal ProteinGrams { get; set; }
    [Range(0, 10000)] public decimal CarbohydrateGrams { get; set; }
    [Range(0, 10000)] public decimal FatGrams { get; set; }
}
