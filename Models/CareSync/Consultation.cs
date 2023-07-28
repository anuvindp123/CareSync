using System;

namespace WebAPI_Wa.Models.CareSync
{
    public class Consultation
    {
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public string ConsultationType { get; set; }
        public DateTime AdminssionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string Diagnosis { get; set; }
        public string Disease { get; set; }
        public string Medication { get; set; }
        public string Treatment { get; set; }
    }
}
