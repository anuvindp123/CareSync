namespace WebAPI_Wa.Dto.Request
{
    public class AddHospitalRequest
    {
        public string HospitalName { get; set; }
        public string RegistrationNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
