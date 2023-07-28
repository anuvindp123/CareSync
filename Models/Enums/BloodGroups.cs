using System.ComponentModel;

namespace WebAPI_Wa.Models.Enums
{
    public enum BloodGroups
    {
        [Description("A Positive")]
        APositive =0,
        [Description("A Negative")]
        ANegative =1,
        [Description("B Positive")]
        BPositive =2,
        [Description("B Negative")]
        BNegative = 3,
        [Description("AB Positive")]
        ABPositive =4,
        [Description("AB Negative")]
        ABNegative = 5,
        [Description("O Positive")]
        OPositive = 6,
        [Description("O Negative")]
        ONegative = 7,
        [Description("Bombay")]
        Bombay = 8,
    }
}
