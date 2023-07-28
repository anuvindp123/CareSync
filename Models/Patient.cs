using System;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models
{
    public class Patient
    {
        public int Id { get; set; } 
        public int AadharId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Sex { get; set; }
        public long uuid { get; set; }
        public long MobileNumber { get; set; }

    }
}
