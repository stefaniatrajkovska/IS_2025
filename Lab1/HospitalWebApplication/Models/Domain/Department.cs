namespace HospitalWebApplication.Models.Domain
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public virtual ICollection<PatientDepartment> PatientDepartments { get; set; }
    }
}
