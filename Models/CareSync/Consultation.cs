using System;
using System.Collections.Generic;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class Consultation
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public ConsultationType ConsultationType { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public string DoctorNote { get; set; }
        public List<Medications> Medications { get; set; }
        public List<Diseases> Disease { get; set; }
        public List<ConsultationSpecialDates> specialDates { get; set; }
        public string Treatment { get; set; }
        public Department Department { get; set; }
        public bool IsConsultationActive { get; set; }
    }
}
