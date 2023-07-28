using System.Collections.Generic;

namespace WebAPI_Wa.Models.CareSync
{
    public class PatientDiseases
    {
        public Patient Patient { get; set; }
        public List<Diseases> Diseases { get; set; }
    }
}
