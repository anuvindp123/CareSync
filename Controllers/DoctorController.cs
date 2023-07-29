using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPI_Wa.Dto.Request;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.CareSync;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly Wa_DbContext _context;
        public DoctorController(Wa_DbContext context)
        {
            _context = context;
        }
        [HttpPost("SaveDoctor")]
        public async Task<ActionResult> SaveDoctor(SaveDoctorRequest request)
        {
            Doctor doctor = new Doctor();
            doctor.Name = request.Name;
            doctor.MobileNumber = request.MobileNumber;
            doctor.Address = request.Address;
            doctor.RegistrationNumber = request.RegistrationNumber;
            doctor.UserName = request.UserName;
            doctor.Password = request.Password;
            _context.doctors.Add(doctor);
            _context.SaveChanges();
            return Ok(doctor);
        }
    }
}
