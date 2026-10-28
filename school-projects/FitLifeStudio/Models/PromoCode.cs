using System.ComponentModel.DataAnnotations;

namespace FitLifeStudio.Models;

public sealed class PromoCode
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, StringLength(32, MinimumLength = 4)]
    [RegularExpression("^[A-Z0-9-]+$")]
    public string Code { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
    public DateTimeOffset? ExpiresAt { get; set; }
    [Range(typeof(decimal), "0.01", "100")] public decimal DiscountPercent { get; set; }
}
