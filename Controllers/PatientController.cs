using Microsoft.AspNetCore.Mvc;
using WebAPI_Wa.Manager;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.Requests;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
        private readonly IPatientManager _patientManager;
        public PatientController(IPatientManager patientManager)
        {
            _patientManager = patientManager;
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
            var ok = _patientManager.AddPatient(user);

            return Ok(true);
        }
    }
}
