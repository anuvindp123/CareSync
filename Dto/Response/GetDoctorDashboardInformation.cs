namespace WebAPI_Wa.Dto.Response
{
    public class GetDoctorDashboardInformation
    {
        public TotalConsultedCases totalConsultedCases { get; set; } = new TotalConsultedCases();   
        public OnGoingConsultation onGoingConsultation { get; set; } = new OnGoingConsultation();
    }
    public class TotalConsultedCases
    {
        public int IpCount { get; set; }
        public int OpPort { get; set; }
    }
    public class OnGoingConsultation
    {
        public int IpCount { get; set; }
        public int OpPort { get; set; }
        public CriticalPersonPercentage criticalPersonPercentage { get; set; } = new CriticalPersonPercentage();
    }
    public class CriticalPersonPercentage
    {
        public int IpCount { get; set; }
        public int OpPort { get; set; }
    }
}
