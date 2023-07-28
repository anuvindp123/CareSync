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
    public class ProductController : ControllerBase
    {
        //private readonly Wa_DbContext _context;

        //public ProductController(Wa_DbContext wa_DbContext)
        //{
        //    _context = wa_DbContext;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        //{
        //    try
        //    {
        //        return await _context.products.ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpGet("/product/{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //    try
        //    {
        //        var product = await _context.products.FindAsync(id);

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
        //[HttpPut("/product/update/{id}")]
        //public async Task<IActionResult> PutProduct(int id, [FromBody]Product product)
        //{
        //    product.id = id;
        //    _context.Entry(product).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductsExists(id))
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

        //[HttpPost("/product/{product}")]
        //public async Task<ActionResult<Product>> PostProduct([FromBody]Product product)
        //{
        //    try
        //    {
        //        if (product.productName == null && product.productDescription == null)
        //            return BadRequest("É necessário o nome e descrição do produto.");


        //        _context.products.Add(product);

        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("Novo Produto", new { Código = product.id, Nome = product.productName, Preço = product.productPrice }, product);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        //[HttpDelete("/product/delete/{id}")]
        //public async Task<ActionResult<Product>> DeleteProduct(int id)
        //{
        //    try
        //    {
        //        var product = await _context.products.FindAsync(id);

        //        if (product == null)
        //            return NotFound();

        //        _context.products.Remove(product);
        //        await _context.SaveChangesAsync();

        //        return product;
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        ////Verifica se há um produto existente e retorna um bool
        //private bool ProductsExists(int id)
        //{
        //    return _context.products.Any(a => a.id == id);
        //}
    }
}

