using Microsoft.AspNetCore.Identity;

namespace HospitalWebApplication.Models.Identity
{
    public class HospitalApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
