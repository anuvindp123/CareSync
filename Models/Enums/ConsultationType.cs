using System.ComponentModel;

namespace WebAPI_Wa.Models.Enums
{
    public enum ConsultationType
    {
        [Description("InPatient")]
        InPatient = 0,
        [Description("OutPatient")]
        OutPatient = 1,
    }

}
