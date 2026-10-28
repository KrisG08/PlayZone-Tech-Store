using System.ComponentModel.DataAnnotations;

namespace FitLifeStudio.Models;

public sealed class Review
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public FitLifeUser User { get; set; } = null!;
    public Guid WorkoutId { get; set; }
    public Workout Workout { get; set; } = null!;

    [Range(1, 5)]
    public int Rating { get; set; }

    [StringLength(2000)]
    public string? Comment { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
