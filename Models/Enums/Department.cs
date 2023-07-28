using System.ComponentModel;

namespace WebAPI_Wa.Models.Enums
{
    public enum Department
    {
        [Description("General Medicine")]
        GeneralMedicine = 0,
        [Description("Orthopaedic")]
        Orthopaedic = 1,
        [Description("Nuerology")]
        Nuerology = 2,
        [Description("Gynaecology")]
        Gynacology = 3,
    }
}
