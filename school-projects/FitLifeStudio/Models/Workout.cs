using System.ComponentModel.DataAnnotations;

namespace FitLifeStudio.Models;

public sealed class Workout
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, StringLength(120)]
    public string Name { get; set; } = string.Empty;

    [StringLength(2000)]
    public string? Description { get; set; }

    public bool IsPremium { get; set; }
    public ICollection<WorkoutExercise> WorkoutExercises { get; set; } = new List<WorkoutExercise>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
