using System.Collections.Generic;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class HospitalDepartmentsLink
    {

        public int Id { get; set; }
        public int hospitalId { get; set; }
        public int departmentId { get; set; }

    }
}
