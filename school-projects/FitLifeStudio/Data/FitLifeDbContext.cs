using FitLifeStudio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitLifeStudio.Data;

public sealed class FitLifeDbContext : IdentityDbContext<FitLifeUser, FitLifeRole, Guid>
{
    public FitLifeDbContext(DbContextOptions<FitLifeDbContext> options) : base(options) { }

    public DbSet<Workout> Workouts => Set<Workout>();
    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<WorkoutExercise> WorkoutExercises => Set<WorkoutExercise>();
    public DbSet<MealPlan> MealPlans => Set<MealPlan>();
    public DbSet<NutritionLog> NutritionLogs => Set<NutritionLog>();
    public DbSet<Subscription> Subscriptions => Set<Subscription>();
    public DbSet<Review> Reviews => Set<Review>();
    public DbSet<PromoCode> PromoCodes => Set<PromoCode>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<WorkoutExercise>()
            .HasKey(link => new { link.WorkoutId, link.ExerciseId });
        builder.Entity<WorkoutExercise>()
            .HasOne(link => link.Workout).WithMany(workout => workout.WorkoutExercises)
            .HasForeignKey(link => link.WorkoutId).OnDelete(DeleteBehavior.Cascade);
        builder.Entity<WorkoutExercise>()
            .HasOne(link => link.Exercise).WithMany(exercise => exercise.WorkoutExercises)
            .HasForeignKey(link => link.ExerciseId).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<MealPlan>().HasOne(plan => plan.User).WithMany(user => user.MealPlans)
            .HasForeignKey(plan => plan.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.Entity<NutritionLog>().HasOne(log => log.User).WithMany(user => user.NutritionLogs)
            .HasForeignKey(log => log.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.Entity<Subscription>().HasOne(subscription => subscription.User).WithMany(user => user.Subscriptions)
            .HasForeignKey(subscription => subscription.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.Entity<Review>().HasOne(review => review.User).WithMany(user => user.Reviews)
            .HasForeignKey(review => review.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.Entity<Review>().HasOne(review => review.Workout).WithMany(workout => workout.Reviews)
            .HasForeignKey(review => review.WorkoutId).OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PromoCode>().HasIndex(code => code.Code).IsUnique();
        builder.Entity<PromoCode>().Property(code => code.DiscountPercent).HasPrecision(5, 2);
        builder.Entity<NutritionLog>().Property(log => log.Calories).HasPrecision(9, 2);
        builder.Entity<NutritionLog>().Property(log => log.ProteinGrams).HasPrecision(8, 2);
        builder.Entity<NutritionLog>().Property(log => log.CarbohydrateGrams).HasPrecision(8, 2);
        builder.Entity<NutritionLog>().Property(log => log.FatGrams).HasPrecision(8, 2);
    }
}
