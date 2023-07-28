using System.ComponentModel.DataAnnotations;

namespace WebAPI_Wa.Models.CareSync
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string HospitalName { get; set; }
        public string RegistrationNumber { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
