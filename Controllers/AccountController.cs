using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Wa.Dto.Request;
using WebAPI_Wa.Models;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly Wa_DbContext _context;
        public AccountController(Wa_DbContext context)
        {
            _context = context;
        }
        [HttpPost("Login")]
        public async Task<ActionResult> Login(LoginRequest loginRequest)
        {
            int id = 0;
            if (loginRequest.Type == 1)
            {
                id = _context.doctors.
                    FirstOrDefault(x => x.UserName == loginRequest.UserName && x.Password == loginRequest.Password).Id;
            }
            if (loginRequest.Type == 2)
            {
                id = _context.patients.
                   FirstOrDefault(x => x.Email == loginRequest.UserName && x.Password == loginRequest.Password).Id;

            }
            return Ok(id);
        }
    }
}
