using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPI_Wa.Manager;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.Requests;

namespace WebAPI_Wa.Controllers
{
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
        public IActionResult PatientRegistration(PatientRegistrationRequest request)
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
            var ok = _patientManager.AddPatient(user);

            return Ok(true);
        }
        [HttpPost]
        public IActionResult UpdatePatientInfo(PatientUpdateInfoRequest request)
        {
            var user = _context.patient.Where(x => x.Id == request.Id).First();
            user.Weight = request.Weight;
            user.Height = request.Height;
            user.BloodGroups = request.BloodGroup;
            user.ProxyName = request.ProxyName;
            user.ProxyEmail = request.ProxyEmail;
            user.ProxyMobileNumber = request.ProxyMobileNumber;
            user.ProxyDOB = request.ProxyDOB;
            user.ProxyAge = request.ProxyAge;
            _context.Update(user);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpPost]
        public IActionResult GetDashBoardMetrics()
    }
}
