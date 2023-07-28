using System.ComponentModel.DataAnnotations;

namespace WebAPI_Wa.Models.CareSync
{
    public class Doctor
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string RegistrationNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
