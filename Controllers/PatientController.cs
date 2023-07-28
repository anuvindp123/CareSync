using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using WebAPI_Wa.Dto.Request;
using WebAPI_Wa.Manager;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.Enums;
using WebAPI_Wa.Models.CareSync;
using WebAPI_Wa.Models.Requests;
using System.ComponentModel;
using System.Reflection;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {

        private readonly IPatientManager _patientManager;
        private readonly Wa_DbContext _context;
        public PatientController(IPatientManager patientManager, Wa_DbContext context)
        {
            _patientManager = patientManager;
            _context = context;
        }
        [HttpPost]
        public ActionResult PatientRegistration(PatientRegistrationRequest request)
        {
            var user = new Patient
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                MiddleName = request.MiddleName,
                AadharId = request.AadharId,
                Email = request.Email,
                MobileNumber = request.MobNumber,
                DOB = request.DOB,
                Password = request.Password,
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
            user.BloodGroups = request.BloodGroup;
            user.ProxyName = request.ProxyName;
            user.ProxyEmail = request.ProxyEmail;
            user.ProxyMobileNumber = request.ProxyMobileNumber;
            user.ProxyDOB = request.ProxyDOB;
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


    }
}
