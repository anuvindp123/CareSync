using System.Collections.Generic;

namespace WebAPI_Wa.Dto.Request
{
    public class AddDiagnosticsRequest
    {
        public string DoctorNote { get; set; }
        public int DeseaseId { get; set; }
        public List<int> Medications { get; set; }
        public string DoctorFindings { get; set; }
        public SpecialDates specialDates { get; set; }

    }
    public class SpecialDates
    {
        public string Date { get; set; }
        public string Note { get; set; }
    }
}
