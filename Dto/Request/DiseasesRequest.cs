using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Dto.Request
{
    public class DiseasesRequest
    {
        public string Name { get; set; }
        public DiseaseType Type { get; set; }
    }
}
