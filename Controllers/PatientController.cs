using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using WebAPI_Wa.Dto.Request;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.Enums;
using WebAPI_Wa.Models.CareSync;
using System.ComponentModel;
using System.Reflection;
using System.Threading.Tasks;
using WebAPI_Wa.Dto.Response;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {

        private readonly Wa_DbContext _context;
        public PatientController(Wa_DbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult PatientRegistration(PatientRegistrationRequest request)
        {
            var user = new Patient
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                AadharId = request.AadharId,
                Email = request.Email,
                MobileNumber = request.MobNumber,
                DOB = request.DOB,
                Password = request.Password,
                BloodGroups = request.BloodGroup,
            };
            _context.patients.Add(user);

            return Ok(true);
        }
        [HttpPost]
        public IActionResult UpdatePatientInfo(PatientUpdateInfoRequest request)
        {
            var user = _context.patients.Where(x => x.Id == request.Id).First();
            user.Weight = request.Weight;
            user.Height = request.Height;
            user.ProxyName = request.ProxyName;
            user.ProxyEmail = request.ProxyEmail;
            user.ProxyMobileNumber = request.ProxyMobileNumber;
            user.ProxyDOB = request.ProxyDOB;
            user.Address = request.Address;
            user.Pincode = request.Pincode;
            user.ProxyAge = request.ProxyAge;
            _context.patients.Update(user);
            _context.SaveChanges();
            return Ok(true);
        }
        public static class EnumDescriptionHelper
        {
            public static List<string> GetEnumDescriptions(Type enumType)
            {
                if (!enumType.IsEnum)
                    throw new ArgumentException("The provided type is not an enum.");

                var enumDescriptions = new List<string>();

                foreach (var enumValue in Enum.GetValues(enumType))
                {
                    string description = GetEnumDescription((Enum)enumValue);
                    enumDescriptions.Add(description);
                }

                return enumDescriptions;
            }

            private static string GetEnumDescription(Enum enumValue)
            {
                FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
                DescriptionAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                return attributes?.FirstOrDefault()?.Description ?? enumValue.ToString();
            }
        }
        [HttpGet]
        public List<string> GetAllDepartments()
        {
            Type enumType = typeof(Department);
            List<string> result = new List<string>();
            List<string> enumDescriptions = EnumDescriptionHelper.GetEnumDescriptions(enumType);

            foreach (string description in enumDescriptions)
            {
                result.Add(description);
            }
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> AddConsultation(CreateConsultationRequest request)
        {
            Consultation consultation = new Consultation();
            SpecialDate dates = new SpecialDate();
            consultation.HospitalId = request.HospitalId;
            consultation.PatientId = request.PatientId;
            consultation.DoctorId = request.DoctorId;
            consultation.AdmissionDate =request.AdmissionDate;
            consultation.DischargeDate = request.DischargeDate;
            consultation.Treatment = request.Treatment;
            consultation.Department = request.Department;
            consultation.IsConsultationActive = request.IsConsultationActive;
            consultation.ConsultationType = request.ConsultationType;
            _context.Add(consultation);
            _context.SaveChanges();
            ConsulationDiseases consulationDiseases = new ConsulationDiseases();
            ConsulationMedications consulationMedication = new ConsulationMedications();
            ConsultationSpecialDates consultationSpecialDates = new ConsultationSpecialDates();
            foreach (var date in request.SpecialDates)
            {
                dates.Date = date.Date;
                dates.Notes = date.Notes;              
                _context.Add(dates);
                _context.SaveChanges();
            }
            foreach (var date in request.SpecialDates)
            {
                consultationSpecialDates.ConsultationId = consultation.Id;
                consultationSpecialDates.SpecialDateId = dates.Id;
                _context.Add(dates);
                _context.SaveChanges();
            }

            foreach (var medication in request.Medications)
            {
                consulationMedication.MedicationId = medication.Id;
                consulationMedication.ConsulationId = consultation.Id;
                _context.Add(consulationMedication);
                _context.SaveChanges();

            }
            foreach (var Disease in request.Disease)
            {
                consulationDiseases.DiseaseId = Disease.Id;
                consulationDiseases.ConsulationId = consultation.Id;
                _context.Add(consulationDiseases);
                _context.SaveChanges();
            }


            return Ok(consultation);
        }

        [HttpPost]
        public async Task<ActionResult> CreateViewLog(ViewLogRequest request)
        {
            var doctor = _context.doctors.FirstOrDefault(x => x.id == request.DoctorId);
            var Patient = _context.patients.FirstOrDefault(x => x.Id == request.PatientId);
            DataViewLogs log = new DataViewLogs();
            if (request.HospitalName != null)
                log.HospitalName = request.HospitalName;
            log.PatientId = request.PatientId;
            log.Time = DateTime.Now;
            log.DoctorName = doctor.Name;
            _context.Add(log);
            _context.SaveChanges();
            return Ok(log);
        }
        [HttpGet]
        public async Task<ActionResult> GetAllLogs(ViewLogRequest request)
        {
            var log = _context.dataViewLogs.Where(x=>x.PatientId== request.PatientId).ToList();            
            return Ok(log);
        }
        [HttpGet]
        public async Task<ActionResult>GetDashBoard(int patientId)
        {
            GetDashboardResponse response = new GetDashboardResponse();
            var consultations = _context.consultations.Where(x=>x.PatientId == patientId).ToList(); 
            var OpType = consultations.Where(x=>x.ConsultationType==ConsultationType.OutPatient).ToList();
            response.OpStats.Count = OpType.Count;
            response.OpStats.LastDateTime = OpType.Select(x=>x.AdmissionDate).LastOrDefault();
            var IpType = consultations.Where(x => x.ConsultationType == ConsultationType.InPatient).ToList();
            double TotalTime = 0;
            double difference;
            foreach(var iptype in IpType)
            {
                var startDate = iptype.AdmissionDate;
                var endDate = iptype.DischargeDate;
                difference = (endDate - startDate).TotalDays;
                TotalTime = TotalTime + difference;
            }
            response.AdmissionStats.TotalAdmittedDays = TotalTime;
            response.AdmissionStats.AverageAdmission = TotalTime / (IpType.Count);
            response.IpStats.Count = IpType.Count;
            response.IpStats.LastDateTime = IpType.Select(x => x.AdmissionDate).LastOrDefault();
            var DiseasesId = _context.patientDiseases.Where(x => x.PatientId == patientId).Select(x=>x.DiseasesId).ToList();
            var Diseases = _context.diseases.Where(x => DiseasesId.Contains(x.Id)).ToList();
            var criticalCount = Diseases.Where(x=>x.Type == DiseaseType.Critical).Count();
            var LifeStyleCount = Diseases.Where(x=>x.Type == DiseaseType.LifeStyle).Count();
            response.DiseaseStats.LifeStyleCount = LifeStyleCount;
            response.DiseaseStats.CriticalCount = criticalCount;
            var log = _context.dataViewLogs.Where(x => x.PatientId == patientId).OrderByDescending(x=>x.Time).ToList();
            response.DataLog.Count = log.Count;
            response.DataLog.LastViewTime = log.Select(x => x.Time).FirstOrDefault();

            return Ok(response);



        }
        public async Task<ActionResult> GetConsultationsByPatient(int patientId)
        {
            ConsultationResponse response = new ConsultationResponse();
            var consultations = _context.consultations.Where(x=>x.PatientId == patientId).ToList();
            var consultationIds = consultations.Select(x=>x.Id).ToList(); 
            var medicationsIds = _context.consulationMedications.Where(x => consultationIds.Contains(x.ConsulationId)).Select(x=>x.MedicationId).ToList();
            var medications = _context.medications.Where(x=>medicationsIds.Contains(x.Id)).ToList();
            var diseaseIds = _context.consulationDiseases.Where(x=>consultationIds.Contains(x.ConsulationId)).Select(x=>x.DiseaseId).ToList();
            var diseases = _context.diseases.Where(x => diseaseIds.Contains(x.Id)).ToList();
            var specialDatesIds = _context.consultationSpecialDates.Where(x=>consultationIds.Contains(x.ConsultationId)).Select(x=>x.SpecialDateId).ToList();
            var specialDates = _context.SpecialDates.Where(x => specialDatesIds.Contains(x.Id)).ToList();
            response.Consultation = consultations;
            response.ConsultationMedication = medications;
            response.ConsultationDisease = diseases;
            response.SpecialDates = specialDates;
            return Ok(response);

        }


    }
}
