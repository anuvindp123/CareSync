using System.Collections.Generic;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class HospitalDepartments
    {
        public Hospital Hospital { get; set; }
        public List<Department> Departments { get; set; }
    }
}
