using System.ComponentModel.DataAnnotations;

namespace HospitalWebApplication.Models.Domain
{
    public class Patient
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime AdmissionDate { get; set; }
        public virtual ICollection<PatientDepartment> PatientDepartments { get; set; }
    }
}
