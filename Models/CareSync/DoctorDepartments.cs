using System.Collections.Generic;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class DoctorDepartments
    {
        public Doctor Doctor { get; set; }
        public List<Department> Department { get; set; }
    }
}
