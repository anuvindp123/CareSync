using System.Collections.Generic;

namespace WebAPI_Wa.Dto.Request
{
    public class AddDiagnosticsRequest
    {
        public string DoctorNote { get; set; }
        public int DeseaseId { get; set; }
        public List<int> Medications { get; set; }
        public string DoctorFindings { get; set; }

    }
    
}
