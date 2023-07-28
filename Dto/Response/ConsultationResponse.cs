using System.Collections.Generic;
using WebAPI_Wa.Models.CareSync;

namespace WebAPI_Wa.Dto.Response
{
    public class ConsultationResponse
    {
        public List<Consultation> Consultation { get; set; }
        public List<Diseases> ConsultationDisease { get; set; }
        public List<Medications> ConsultationMedication { get; set; }
        public List<SpecialDate> SpecialDates { get; set; }
    }
}
