using System.Collections.Generic;

namespace WebAPI_Wa.Dto.Response
{
    public class GetHospitalCountRespone
    {
        public List<HospitalsDto> Hospitals { get; set; }
    }
    public class HospitalsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
