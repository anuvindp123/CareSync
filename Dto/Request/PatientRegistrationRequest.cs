using System;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Dto.Request
{
    public class PatientRegistrationRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public string AadharId { get; set; }
        public string MobNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
<<<<<<< HEAD
        public string Sex { get; set; }
=======
        public BloodGroups BloodGroup { get; set; }
>>>>>>> 05764fc4fe9ab337161e77225584b9d5a2d64d90

    }
    public class PatientUpdateInfoRequest
    {
<<<<<<< HEAD
        public string Height { get; set; }
        public string Weight { get; set; }
        public BloodGroups BloodGroup { get; set; }
=======
        public float Height { get; set; }
        public float Weight { get; set; }       
>>>>>>> 05764fc4fe9ab337161e77225584b9d5a2d64d90
        public int Id { get; set; }
        public string ProxyName { get; set; }
        public string ProxyMobileNumber { get; set; }
        public string ProxyEmail { get; set; }
        public string ProxyAge { get; set; }
        public DateTime ProxyDOB { get; set; }
    }
}
