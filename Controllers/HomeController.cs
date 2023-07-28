using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Wa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        //Métodos de Autorização para acesso de usuários através do Token JWT. 
        //Testes de Rotas e Autenticação.
        //[HttpGet, Route("anonymous")]
        //[AllowAnonymous]
        //public string Anonymous() => "Anônimo";

        //[HttpGet, Route("authenticated")]
        //[Authorize]
        //public string Authenticated() => $"Autenticado - {User.Identity.Name}";

        //[HttpGet, Route("dev")]
        //[Authorize(Roles = "company, dev")]
        //public string Dev() => "Software Developer";

        //[HttpGet, Route("company")]
        //[Authorize(Roles = "company")]
        //public string Company() => "Empresa";
    }
  
}
