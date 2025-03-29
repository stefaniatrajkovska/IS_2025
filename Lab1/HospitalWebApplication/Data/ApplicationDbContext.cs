using HospitalWebApplication.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HospitalWebApplication.Models.Domain;

namespace HospitalWebApplication.Data;

public class ApplicationDbContext : IdentityDbContext<HospitalApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<HospitalWebApplication.Models.Domain.Patient> Patient { get; set; } = default!;

public DbSet<HospitalWebApplication.Models.Domain.Department> Department { get; set; } = default!;

public DbSet<HospitalWebApplication.Models.Domain.Treatment> Treatment { get; set; } = default!;
}
