using System.Collections.Generic;

namespace WebAPI_Wa.Models.CareSync
{
    public class DoctorHospitalsLink
    {
        public int Id { get; set; }
        public int doctorId { get; set; }
        public int hospitalId { get; set; }
    }


}
