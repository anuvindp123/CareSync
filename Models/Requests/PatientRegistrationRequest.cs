using System;

namespace WebAPI_Wa.Models.Requests
{
    public class PatientRegistrationRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DOB { get; set; }
        public int AadharId { get; set; }
        public long MobNumber { get; set; }
        public string Email { get; set;}
        public string Password { get; set;}
    }
}
