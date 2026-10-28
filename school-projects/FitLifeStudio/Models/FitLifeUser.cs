using Microsoft.AspNetCore.Identity;

namespace FitLifeStudio.Models;

public sealed class FitLifeUser : IdentityUser<Guid>
{
    public ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    public ICollection<MealPlan> MealPlans { get; set; } = new List<MealPlan>();
    public ICollection<NutritionLog> NutritionLogs { get; set; } = new List<NutritionLog>();
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
