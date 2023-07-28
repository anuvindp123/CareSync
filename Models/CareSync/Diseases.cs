using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class Diseases
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DiseaseType Type { get; set; }
    }
}
