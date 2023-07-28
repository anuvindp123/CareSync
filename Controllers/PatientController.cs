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
using WebAPI_Wa.CommonFunctions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI_Wa.Dto.Response;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly Wa_DbContext _context;
        public PatientController(Wa_DbContext context)
        {
            _context = context;
        }
        [HttpPost("PatientRegistration")]
        public async Task<ActionResult> PatientRegistration(PatientRegistrationRequest request)
        {
            var user = new Patient
            {
                FirstName = request.FirstName,
                LastName = request.LastName,

                AadharId = request.AadharId,
                Email = request.Email,
                MobileNumber = request.MobNumber,
                DOB = request.DOB.Date,
                Password = request.Password,
                Sex = request.Sex
                ,
                uuid = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString()
            };
            _context.patients.Add(user);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpPost("UpdatePatientInfo")]
        public async Task<ActionResult> UpdatePatientInfo(PatientUpdateInfoRequest request)
        {
            var user = await _context.patients.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            user.Weight = request.Weight;
            user.Height = request.Height;
            user.BloodGroups = request.BloodGroup.GetEnumDescription();
            user.ProxyName = request.ProxyName;
            user.ProxyEmail = request.ProxyEmail;
            user.ProxyMobileNumber = request.ProxyMobileNumber;
            user.ProxyDOB = request.ProxyDOB.Date;
            _context.patients.Update(user);
            _context.SaveChanges();
            return Ok(true);
        }

        [HttpGet("GetPatientBasicInformation")]
        public async Task<ActionResult> GetPatientBasicInformation(string patientUuid)
        {
            var patient = await _context.patients.Where(x => x.uuid == patientUuid).FirstOrDefaultAsync();
            GetPatientBasicInformationResponse obj = new GetPatientBasicInformationResponse();
            if (patient != null)
            {
                obj.patientName = patient.FirstName + " " + patient.LastName;
                obj.phoneNumber = patient.MobileNumber;
                obj.dateOfBirth = patient.DOB.ToString();
                obj.email = patient.Email;
                obj.Id = patient.Id;
            }
            return Ok(obj);
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


    }
}
