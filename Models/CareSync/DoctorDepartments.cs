﻿using System.Collections.Generic;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Models.CareSync
{
    public class DoctorDepartments
    {
        public int Id { get; set; }
        public int doctorId { get; set; }
        public int departmentId { get; set; }
    }
}
