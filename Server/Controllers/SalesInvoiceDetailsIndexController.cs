using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Shared;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesInvoiceDetailsIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesInvoiceDetailsIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesInvoiceDetailsIndex
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesInvoice_Details>>> GetSalesInvoice_Details()
        {
            return await _context.SalesInvoice_Details.ToListAsync();
        }

        // GET: api/SalesInvoiceDetailsIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesInvoice_Details>> GetSalesInvoice_Details(int id)
        {
            var salesInvoice_Details = _context.SalesInvoice_Details.Where(p => p.Header_ID == id).ToList();

            if (salesInvoice_Details == null)
            {
                return NotFound();
            }

            return Ok(salesInvoice_Details);
        }

        // PUT: api/SalesInvoiceDetailsIndex/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesInvoice_Details(int id, SalesInvoice_Details salesInvoice_Details)
        {
            if (id != salesInvoice_Details.ID)
            {
                return BadRequest();
            }

            _context.Entry(salesInvoice_Details).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesInvoice_DetailsExists(id))
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

        // POST: api/SalesInvoiceDetailsIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesInvoice_Details>> PostSalesInvoice_Details(SalesInvoice_Details salesInvoice_Details)
        {
            _context.SalesInvoice_Details.Add(salesInvoice_Details);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesInvoice_Details", new { id = salesInvoice_Details.ID }, salesInvoice_Details);
        }

        // DELETE: api/SalesInvoiceDetailsIndex/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesInvoice_Details>> DeleteSalesInvoice_Details(int id)
        {
            var salesInvoice_Details = await _context.SalesInvoice_Details.FindAsync(id);
            if (salesInvoice_Details == null)
            {
                return NotFound();
            }

            _context.SalesInvoice_Details.Remove(salesInvoice_Details);
            await _context.SaveChangesAsync();

            return salesInvoice_Details;
        }

        private bool SalesInvoice_DetailsExists(int id)
        {
            return _context.SalesInvoice_Details.Any(e => e.ID == id);
        }
    }
}
