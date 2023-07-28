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
    [Authorize]
    public class VehicleController : ControllerBase
    {
        private readonly Wa_DbContext _context;

        public VehicleController(Wa_DbContext wa_DbContext)
        {
            _context = wa_DbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            try
            {
                return await _context.vehicles.ToListAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/vehicle/{id}")]
        public async Task<ActionResult<Vehicle>> GetTeam(int id)
        {
            try
            {
                var vehicle = await _context.vehicles.FindAsync(id);

                if (vehicle == null)
                {
                    return NotFound();
                }

                return vehicle;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Como é uma aplicação simples à nível de teste resolvi não optar por ViewModels como parâmetro do FromBody
        [HttpPut("/vehicle/update/{id}")]
        public async Task<IActionResult> PutVehicle(int id, [FromBody]Vehicle vehicle)
        {
            vehicle.Id = id;
            _context.Entry(vehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("/vehicle/{vehicle}")]
        public async Task<ActionResult<Vehicle>> PostVehicle([FromBody]Vehicle vehicle)
        {
            try
            {
                _context.vehicles.Add(vehicle);

                await _context.SaveChangesAsync();

                return CreatedAtAction("Novo Veículo", new
                {
                    Código = vehicle.Id,
                    Placa = vehicle.plateLicenseVehicle
                }, vehicle);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("/vehicle/delete/{id}")]
        public async Task<ActionResult<Vehicle>> DeleteVehicle(int id)
        {
            try
            {
                var vehicle = await _context.vehicles.FindAsync(id);

                if (vehicle == null)
                    return NotFound();

                _context.vehicles.Remove(vehicle);
                await _context.SaveChangesAsync();

                return vehicle;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Verifica se há um veículo existente e retorna um bool
        private bool VehicleExists(int id)
        {
            return _context.vehicles.Any(a => a.Id == id);
        }
    }
}
