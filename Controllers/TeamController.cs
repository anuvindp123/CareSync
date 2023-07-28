using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Wa.Models;

namespace WebAPI_Wa.Controllers
{
    // [Authorize]
    public class TeamController : ControllerBase
    {
        //private readonly Wa_DbContext _context;

        //public TeamController(Wa_DbContext wa_DbContext)
        //{
        //    _context = wa_DbContext;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        //{
        //    try
        //    {
        //        return await _context.teams.ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/team/{id}")]
        //public async Task<ActionResult<Team>> GetTeam(int id)
        //{
        //    try
        //    {
        //        var team = await _context.teams.FindAsync(id);

        //        if (team == null)
        //        {
        //            return NotFound();
        //        }

        //        return team;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Como é uma aplicação simples à nível de teste resolvi não optar por ViewModels como parâmetro do FromBody
        //[HttpPut("/team/update/{id}")]
        //public async Task<IActionResult> PutTeam(int id, [FromBody] Team team)
        //{
        //    team.id = id;
        //    _context.Entry(team).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TeamExists(id))
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

        //[HttpPost("/team/{team}")]
        //public async Task<ActionResult<Team>> PostTeam([FromBody] Team team)
        //{
        //    try
        //    {
        //        _context.teams.Add(team);

        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("Novo Time", new { Código = team.id, Nome = team.teamName, Descrição = team.teamDescription }, team);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpDelete("/team/delete/{id}")]
        //public async Task<ActionResult<Team>> DeleteTeam(int id)
        //{
        //    try
        //    {
        //        var team = await _context.teams.FindAsync(id);

        //        if (team == null)
        //            return NotFound();

        //        _context.teams.Remove(team);
        //        await _context.SaveChangesAsync();

        //        return team;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Verifica se há um time existente e retorna um bool
        //private bool TeamExists(int id)
        //{
        //    return _context.teams.Any(a => a.id == id);
        //}
    }
}
