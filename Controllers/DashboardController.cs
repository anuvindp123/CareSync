using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using WebAPI_Wa.Models;
using WebAPI_Wa.Dto.Response;
using WebAPI_Wa.Dto.Request;
using WebAPI_Wa.Models.CareSync;
using System.Linq;
using WebAPI_Wa.Models.Enums;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly Wa_DbContext _context;
        public DashboardController(Wa_DbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetHospitalCount(int doctorId)
        {
            try
            {
                GetHospitalCountRespone list = new GetHospitalCountRespone();
                list.Hospitals = new List<HospitalsDto>();

                var hospitalHospitalLink = _context.doctorHospitalsLink.Where(x => x.doctorId == doctorId).ToList();
                foreach (var item in hospitalHospitalLink)
                {
                    var hospitalInfo = _context.hospitals.Where(x => x.Id == item.hospitalId).FirstOrDefault();
                    HospitalsDto hospitalsDto1 = new HospitalsDto();
                    hospitalsDto1.Id = hospitalInfo.Id; hospitalsDto1.Name = hospitalInfo.HospitalName;
                    list.Hospitals.Add(hospitalsDto1);
                }
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

        [HttpPost("DoctorPatientSync")]
        public async Task<ActionResult> DoctorPatientSync(DoctorPatientSyncRequest doctorPatientSyncRequest)
        {
            var syncData = new DoctorPatientHospitalLinks();
            syncData.DoctorId = doctorPatientSyncRequest.DoctorId;
            syncData.DoctorId = doctorPatientSyncRequest.DoctorId;
            _context.doctorPatientHospitalLinks.Add(syncData);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpPost("DoctorDashboardPrivate")]
        public async Task<ActionResult>DoctorDashboardPrivate(int DoctorId)
        {
            GetPrivateDoctorDashboardInformation response = new GetPrivateDoctorDashboardInformation();
            var consultations = _context.consultations.Where(x=>x.HospitalId == null && x.DoctorId == DoctorId && x.ConsultationType == ConsultationType.OutPatient).ToList();
            response.totalConsultedCases.opCount = consultations.Count;
            var onGoingConsultations = consultations.Where(x=>x.IsConsultationActive && x.ConsultationType == ConsultationType.OutPatient).ToList();
            response.onGoingConsultation.opCount = onGoingConsultations.Count;
            var PatientIds = consultations.Select(x => x.PatientId).ToList();
            var patientDiseases = _context.patientDiseases.Where(x=>PatientIds.Contains(x.PatientId)).Select(x=>x.DiseasesId).ToList();
            var diseases = _context.diseases.Where(x => patientDiseases.Contains(x.Id)).ToList();
            var CriticalCount = diseases.Where(x=>x.Type ==  DiseaseType.Critical).Count();
            var LifeStyleCount = diseases.Where(x=>x.Type ==  DiseaseType.LifeStyle).Count();
            response.CriticalCount = CriticalCount;
            response.LifeStyle = LifeStyleCount;
            return Ok(response);

        }

    }
}
