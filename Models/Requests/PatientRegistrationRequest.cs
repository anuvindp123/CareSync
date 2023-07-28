using System;
using WebAPI_Wa.Models.Enums;

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
    public class PatientUpdateInfoRequest
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public BloodGroups BloodGroup { get; set; }
        public int Id { get; set; }
        public string ProxyName { get; set; }
        public string ProxyMobileNumber { get; set; }
        public string ProxyEmail { get; set; }
        public string ProxyAge { get; set; }
        public DateTime ProxyDOB { get; set; }
    }
}
