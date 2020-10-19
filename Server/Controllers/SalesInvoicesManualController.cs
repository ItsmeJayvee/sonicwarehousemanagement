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
    public class SalesInvoicesManualController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesInvoicesManualController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesInvoicesManual
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesInvoice>>> GetSales_Invoice()
        {
            return await _context.Sales_Invoice.ToListAsync();
        }

        // GET: api/SalesInvoicesManual/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesInvoice>> GetSalesInvoice(int id)
        {
            var salesInvoice = await _context.Sales_Invoice.FindAsync(id);

            if (salesInvoice == null)
            {
                return NotFound();
            }

            return salesInvoice;
        }

        // PUT: api/SalesInvoicesManual/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesInvoice(int id, SalesInvoice salesInvoice)
        {
            if (id != salesInvoice.ID)
            {
                return BadRequest();
            }

            _context.Entry(salesInvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesInvoiceExists(id))
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

        // POST: api/SalesInvoicesManual
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesInvoice>> PostSalesInvoice(SalesInvoice salesInvoice)
        {
            _context.Sales_Invoice.Add(salesInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesInvoice", new { id = salesInvoice.ID }, salesInvoice);
        }

        // DELETE: api/SalesInvoicesManual/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesInvoice>> DeleteSalesInvoice(int id)
        {
            var salesInvoice = await _context.Sales_Invoice.FindAsync(id);
            if (salesInvoice == null)
            {
                return NotFound();
            }

            _context.Sales_Invoice.Remove(salesInvoice);
            await _context.SaveChangesAsync();

            return salesInvoice;
        }

        private bool SalesInvoiceExists(int id)
        {
            return _context.Sales_Invoice.Any(e => e.ID == id);
        }
    }
}
