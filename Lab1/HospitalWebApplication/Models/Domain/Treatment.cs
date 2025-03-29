namespace HospitalWebApplication.Models.Domain
{
    public class Treatment
    {
        public Guid Id { get; set; }
        public DateTime DateAdministered { get; set; }
        public string FollowUpRequired { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
    }
}
