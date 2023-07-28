namespace WebAPI_Wa.Models.CareSync
{
    public class DoctorPatientHospitalLinks
    {
        public int Id { get; set; }
        public int? HospitalId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
    }
}
