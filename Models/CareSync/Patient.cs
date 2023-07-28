using System;
using System.ComponentModel.DataAnnotations;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class Patient
    {
        public int Id { get; set; }
        public long AadharId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Pincode { get; set; }
        public Gender Sex { get; set; }
        public long uuid { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public BloodGroups BloodGroups { get; set; }
        public long MobileNumber { get; set; }
        public string ProxyName { get; set; }
        public string ProxyMobileNumber { get; set; }
        public string ProxyEmail { get; set; }
        public string ProxyAge { get; set; }
        public DateTime ProxyDOB { get; set; }

    }
}
