using FitLifeStudio.Models;

namespace FitLifeStudio.Services;

public interface IWorkoutAccessService
{
    bool CanAccess(Workout workout, IEnumerable<Subscription> subscriptions, DateTimeOffset now);
}

public sealed class WorkoutAccessService : IWorkoutAccessService
{
    public bool CanAccess(Workout workout, IEnumerable<Subscription> subscriptions, DateTimeOffset now)
    {
        ArgumentNullException.ThrowIfNull(workout);
        ArgumentNullException.ThrowIfNull(subscriptions);
        if (!workout.IsPremium) return true;

        return subscriptions.Any(subscription => subscription.IsActive
            && subscription.StartsAt <= now
            && subscription.EndsAt > now);
    }
}
