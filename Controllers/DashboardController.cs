using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using WebAPI_Wa.Models;
using WebAPI_Wa.Dto.Response;
using WebAPI_Wa.Dto.Request;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetHospitalCount()
        {
            try
            {
                GetHospitalCountRespone list = new GetHospitalCountRespone();
                list.Hospitals = new List<HospitalsDto>();
                HospitalsDto hospitalsDto1 = new HospitalsDto();
                hospitalsDto1.Id = 1; hospitalsDto1.Name = "MIMS";
                HospitalsDto hospitalsDto2 = new HospitalsDto();
                hospitalsDto2.Id = 2; hospitalsDto2.Name = "Almas";

                list.Hospitals.Add(hospitalsDto1); list.Hospitals.Add(hospitalsDto2);
                return Ok(list);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetDoctorDashboardInf")]
        public async Task<ActionResult> GetDoctorDashboardInf(int doctorid, int hospitalid)
        {
            GetDoctorDashboardInformation getDoctorDashboardInformation = new GetDoctorDashboardInformation();

            getDoctorDashboardInformation.totalConsultedCases.opCount = 1000;
            getDoctorDashboardInformation.totalConsultedCases.ipCount = 250;

            getDoctorDashboardInformation.onGoingConsultation.ipCount = 25;
            getDoctorDashboardInformation.onGoingConsultation.opCount = 10;

            getDoctorDashboardInformation.onGoingConsultation.criticalPersonPercentage.ipCount = 4;
            getDoctorDashboardInformation.onGoingConsultation.criticalPersonPercentage.opCount = 5;

            return Ok(getDoctorDashboardInformation);
        }

        [HttpPost]
        public async Task<ActionResult> DoctorPatientSync(DoctorPatientSyncRequest doctorPatientSyncRequest)
        {
            return Ok(true);
        }
    }
}
