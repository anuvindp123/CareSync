using System.Collections.Generic;

namespace WebAPI_Wa.Models.CareSync
{
    public class DoctorHospitals
    {
        public Doctor Doctor { get; set; }
        public List<Hospital> Hospital { get; set; }
    }
}
