namespace WebAPI_Wa.Dto.Request
{
    public class ViewLogRequest
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string? HospitalName { get; set;}   
    }
}
