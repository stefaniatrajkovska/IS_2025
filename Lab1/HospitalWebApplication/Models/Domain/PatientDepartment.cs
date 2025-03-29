namespace HospitalWebApplication.Models.Domain
{
    public class PatientDepartment
    {
        public Guid Id { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public Department Department { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime DateAssigned { get; set; }
    }
}
