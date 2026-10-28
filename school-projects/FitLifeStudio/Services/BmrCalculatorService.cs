namespace FitLifeStudio.Services;

public enum BmrEquation
{
    Male,
    Female
}

public enum FitnessGoal
{
    WeightLoss,
    Maintain,
    MuscleGain
}

public sealed record BmrInput(decimal WeightKg, decimal HeightCm, int AgeYears, BmrEquation Equation, FitnessGoal Goal);
public sealed record BmrResult(decimal BasalMetabolicRate, decimal DailyTarget);

public interface IBmrCalculatorService
{
    BmrResult Calculate(BmrInput input);
}

public sealed class BmrCalculatorService : IBmrCalculatorService
{
    public BmrResult Calculate(BmrInput input)
    {
        ArgumentNullException.ThrowIfNull(input);
        if (input.WeightKg <= 0) throw new ArgumentOutOfRangeException(nameof(input.WeightKg), "Weight must be positive.");
        if (input.HeightCm <= 0) throw new ArgumentOutOfRangeException(nameof(input.HeightCm), "Height must be positive.");
        if (input.AgeYears <= 0) throw new ArgumentOutOfRangeException(nameof(input.AgeYears), "Age must be positive.");

        var offset = input.Equation switch
        {
            BmrEquation.Male => 5m,
            BmrEquation.Female => -161m,
            _ => throw new ArgumentOutOfRangeException(nameof(input.Equation))
        };
        var bmr = 10m * input.WeightKg + 6.25m * input.HeightCm - 5m * input.AgeYears + offset;
        var multiplier = input.Goal switch
        {
            FitnessGoal.WeightLoss => 0.85m,
            FitnessGoal.Maintain => 1.00m,
            FitnessGoal.MuscleGain => 1.15m,
            _ => throw new ArgumentOutOfRangeException(nameof(input.Goal))
        };

        return new BmrResult(Round(bmr), Round(bmr * multiplier));
    }

    private static decimal Round(decimal value) => Math.Round(value, 2, MidpointRounding.AwayFromZero);
}
