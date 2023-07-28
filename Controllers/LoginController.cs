using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebAPI_Wa.Models;
using WebAPI_Wa.Repositories;
using WebAPI_Wa.Services;

namespace WebAPI_Wa.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {

        //private readonly Wa_DbContext _dbContext;

        //public LoginController(Wa_DbContext wa_DbContext)
        //{
        //    _dbContext = wa_DbContext;
        //}

        //[HttpPost, Route("/login")]
        //[AllowAnonymous]
        //public async Task<ActionResult<dynamic>> AsyncAuthenticate([FromBody] User userModel)
        //{
        //    var user = UserRepository.Get(userModel.userName, userModel.password);
            
        //    if (user == null)
        //        return BadRequest(new { message = "Usuário ou senha inválidos." });

        //    var token = TokenService.GenerateToken(user);
        //    var refreshToken = TokenService.GenerateRefreshToken();
        //    TokenService.SaveRefreshToken(user.userName, refreshToken);

        //    //Ocultar a senha.
        //    user.password = "";

        //    return new
        //    {
        //        user = user,
        //        token = token,
        //        refreshToken = refreshToken
        //    };
        //}

        //[HttpPost, Route("/refresh")]
        //public IActionResult Refresh(string token, string refreshToken)
        //{
        //    var principal = TokenService.GetPrincipalFromExpiredToken(token);
        //    var userName = principal.Identity.Name;
        //    var savedRefreshToken = TokenService.GetRefreshToken(userName);

        //    if (savedRefreshToken != refreshToken)
        //        throw new SecurityTokenException("Refresh Token inválido");

        //    var newJwtToken = TokenService.GenerateToken(principal.Claims);
        //    var newRefreshToken = TokenService.GenerateRefreshToken();

        //    TokenService.DeleteRefreshToken(userName, refreshToken);
        //    TokenService.SaveRefreshToken(userName, newRefreshToken);

        //    return new ObjectResult(new
        //    {
        //        token = newJwtToken,
        //        refreshToken = newRefreshToken
        //    });
        //}
    }
}
