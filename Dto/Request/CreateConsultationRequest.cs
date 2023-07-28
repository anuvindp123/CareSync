using System.Collections.Generic;
using System;
using WebAPI_Wa.Models.CareSync;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Dto.Request
{
    public class CreateConsultationRequest
    {
        public int PatientId { get; set; }
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public ConsultationType ConsultationType { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string DoctorNote { get; set; }
        public List<Medications> Medications { get; set; }
        public List<Diseases> Disease { get; set; }
        public string Treatment { get; set; }
        public Department Department { get; set; }
        public bool IsConsultationActive { get; set; }
    }
}
