using WebAPI_Wa.Models.CareSync;

namespace WebAPI_Wa.Dto.Response
{
    public class GetPatientBasicInformationResponse
    {
        public int Id { get; set; }
        public string patientName { get; set; }
        public string dateOfBirth { get; set; }

        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
}
