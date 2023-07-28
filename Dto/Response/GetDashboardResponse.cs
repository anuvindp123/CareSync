using System;
using WebAPI_Wa.Models.CareSync;

namespace WebAPI_Wa.Dto.Response
{
    public class GetDashboardResponse
    {
        public OpConsulatation OpStats { get; set; }
        public IpConsulatation IpStats { get; set; }
        public AdmissionStats AdmissionStats { get; set; }
        public DiseaseStats DiseaseStats { get; set; }
        public DataViewLog DataLog { get; set; }

        
    }
    public class OpConsulatation
    {
        public int Count { get; set; }
        public DateTime LastDateTime { get; set; }
    }
    public class IpConsulatation
    {
        public int Count { get; set; }
        public DateTime LastDateTime { get; set; }
    }
    public class AdmissionStats
    {
        public double TotalAdmittedDays { get; set; }
        public double AverageAdmission { get; set; }
    }
    public class DiseaseStats 
    {
        public int CriticalCount { get; set; }
        public int LifeStyleCount { get; set; }

    }
    public class DataViewLog {
        public int Count { get; set; }
        public DateTime LastViewTime { get; set; }
    }



}
