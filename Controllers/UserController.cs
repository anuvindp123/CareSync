using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebAPI_Wa.Models;

namespace WebAPI_Wa.Controllers
{
    [Authorize]
    public class UserController : ControllerBase
    {
        //private readonly Wa_DbContext _context;

        //public UserController(Wa_DbContext wa_DbContext)
        //{
        //    _context = wa_DbContext;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        //{
        //    try
        //    {
        //        return await _context.users.ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/user/{id}")]
        //public async Task<ActionResult<User>> GetUser(int id)
        //{
        //    try
        //    {
        //        var product = await _context.users.FindAsync(id);

        //        if (product == null)
        //        {
        //            return NotFound();
        //        }

        //        return product;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Como é uma aplicação simples à nível de teste resolvi não optar por ViewModels como parâmetro do FromBody
        //[HttpPut("/user/update/{id}")]
        //public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] User user)
        //{
        //    user.id = id;
        //    _context.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //[HttpPost("/user/{user}")]
        //public async Task<ActionResult<User>> PostUser([FromBody] User user)
        //{
        //    try
        //    {
        //        GenerateMD5(user.password);
        //        _context.users.Add(user);

        //        await _context.SaveChangesAsync();

        //        return Ok(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpDelete("/user/delete/{id}")]
        //public async Task<ActionResult<User>> DeleteUser(int id)
        //{
        //    try
        //    {
        //        var user = await _context.users.FindAsync(id);

        //        if (user == null)
        //            return NotFound();

        //        _context.users.Remove(user);
        //        await _context.SaveChangesAsync();

        //        return user;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Verifica se há um usuário existente e retorna um bool
        //private bool UserExists(int id)
        //{
        //    return _context.users.Any(a => a.id == id);
        //}

        ////Gera MD5 para salvar como HASH a senha do usuário seja em memória ou no banco de dados.
        //public static string GenerateMD5(string input)
        //{
        //    MD5 hash = MD5.Create();
        //    byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        //    StringBuilder sBuilder = new StringBuilder();
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        sBuilder.Append(data[i].ToString("x2"));
        //    }
        //    return sBuilder.ToString();
        //}
    }
}
