namespace LensCity.Infrastructure.Data.Entities;

public abstract class AppUser : IdentityUser<int>
{
    public string? FullName { get; set; }
}