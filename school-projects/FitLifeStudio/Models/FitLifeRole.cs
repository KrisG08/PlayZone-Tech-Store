using Microsoft.AspNetCore.Identity;

namespace FitLifeStudio.Models;

public sealed class FitLifeRole : IdentityRole<Guid>
{
    public FitLifeRole() { }
    public FitLifeRole(string roleName) : base(roleName) { }
}
