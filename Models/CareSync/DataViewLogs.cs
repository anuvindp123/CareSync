using System;

namespace WebAPI_Wa.Models.CareSync
{
    public class DataViewLogs
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string HospitalName { get; set; }
        public DateTime Time { get; set; }
    }
}
