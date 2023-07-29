using System.ComponentModel;

namespace WebAPI_Wa.Models.Enums
{
    public enum BloodGroups
    {
        [Description("A +ve")]
        APositive =0,
        [Description("A -ve")]
        ANegative =1,
        [Description("B +ve")]
        BPositive =2,
        [Description("B -ve")]
        BNegative = 3,
        [Description("AB +ve")]
        ABPositive =4,
        [Description("AB -ve")]
        ABNegative = 5,
        [Description("O +ve")]
        OPositive = 6,
        [Description("O -ve")]
        ONegative = 7,
        [Description("Bombay")]
        Bombay = 8,
    }
}
