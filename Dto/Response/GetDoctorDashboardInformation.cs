namespace WebAPI_Wa.Dto.Response
{
    public class GetDoctorDashboardInformation
    {
        public TotalConsultedCases totalConsultedCases { get; set; } = new TotalConsultedCases();   
        public OnGoingConsultation onGoingConsultation { get; set; } = new OnGoingConsultation();
    }
    public class TotalConsultedCases
    {
        public int ipCount { get; set; }
        public int opCount { get; set; }
    }
    public class OnGoingConsultation
    {
        public int ipCount { get; set; }
        public int opCount { get; set; }
        public CriticalPersonCount criticalPersonPercentage { get; set; } = new CriticalPersonCount();
    }
    public class CriticalPersonCount
    {
        public int ipCount { get; set; }
        public int opCount { get; set; }
    }
    public class GetPrivateDoctorDashboardInformation
    {
        public TotalConsultedCases totalConsultedCases { get; set; } = new TotalConsultedCases();
        public OnGoingConsultation onGoingConsultation { get; set; } = new OnGoingConsultation();
        public int CriticalCount { get; set; }
        public int LifeStyle { get; set; }
    }
}
