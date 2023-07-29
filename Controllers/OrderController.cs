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
    public class OrderController : ControllerBase
    {
        //private readonly Wa_DbContext _context;

        //public OrderController(Wa_DbContext wa_DbContext)
        //{
        //    _context = wa_DbContext;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        //{
        //    try
        //    {
        //        return await _context.orders.ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/order/{id}")]
        //public async Task<ActionResult<Order>> GetOrder(int id)
        //{
        //    try
        //    {
        //        var order = await _context.orders.FindAsync(id);

        //        if (order == null)
        //        {
        //            return NotFound();
        //        }

        //        return order;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Como é uma aplicação simples à nível de teste resolvi não optar por ViewModels como parâmetro do FromBody
        //[HttpPut("/order/update/{id}")]
        //public async Task<IActionResult> PutOrder(int id, [FromBody] Order order)
        //{
        //    order.id = id;
        //    _context.Entry(order).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OrderExists(id))
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

        //[HttpPost("/order/{order}")]
        //public async Task<ActionResult<Order>> PostOrder([FromBody]Order order)
        //{
        //    try
        //    {
        //        _context.orders.Add(order);

        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("Novo Pedido Realizado", new
        //        {
        //            Código = order.id,
        //            DataInicial = order.orderDateStart,
        //            DataEntrega = order.orderDateDelivery,
        //            Time = order.team.teamName,
        //            Produto = order.product.productName,
        //            Veículo = order.vehicle.plateLicenseVehicle

        //        }, order);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpDelete("/order/delete/{id}")]
        //public async Task<ActionResult<Order>> DeleteOrder(int id)
        //{
        //    try
        //    {
        //        var order = await _context.orders.FindAsync(id);

        //        if (order == null)
        //            return NotFound();

        //        _context.orders.Remove(order);
        //        await _context.SaveChangesAsync();

        //        return order;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Verifica se há uma encomenda existente e retorna um bool
        //private bool OrderExists(int id)
        //{
        //    return _context.orders.Any(a => a.id == id);
        //}
    }
}
