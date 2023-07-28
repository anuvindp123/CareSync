using System;
using System.ComponentModel.DataAnnotations;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class Patient
    {
        public int Id { get; set; }
        public string AadharId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string uuid { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BloodGroups { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public int Pincode { get; set; }    
        public string ProxyName { get; set; }
        public string ProxyMobileNumber { get; set; }
        public string ProxyEmail { get; set; }


        public DateTime ProxyDOB { get; set; }

    }
}
