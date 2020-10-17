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
    public class ISR_DailySalesInvoiceManualController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ISR_DailySalesInvoiceManualController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ISR_DailySalesInvoiceManual
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ISR_DailySalesInvoice>>> GetISR_Daily_Sales_Invoices()
        {
            return await _context.ISR_Daily_Sales_Invoices.ToListAsync();
        }

        // GET: api/ISR_DailySalesInvoiceManual/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ISR_DailySalesInvoice>> GetISR_DailySalesInvoice(int id)
        {
            var iSR_DailySalesInvoice = await _context.ISR_Daily_Sales_Invoices.FindAsync(id);

            if (iSR_DailySalesInvoice == null)
            {
                return NotFound();
            }

            return iSR_DailySalesInvoice;
        }

        // PUT: api/ISR_DailySalesInvoiceManual/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutISR_DailySalesInvoice(int id, ISR_DailySalesInvoice iSR_DailySalesInvoice)
        {
            if (id != iSR_DailySalesInvoice.ID)
            {
                return BadRequest();
            }

            _context.Entry(iSR_DailySalesInvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ISR_DailySalesInvoiceExists(id))
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

        // POST: api/ISR_DailySalesInvoiceManual
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ISR_DailySalesInvoice>> PostISR_DailySalesInvoice(ISR_DailySalesInvoice iSR_DailySalesInvoice)
        {
            _context.ISR_Daily_Sales_Invoices.Add(iSR_DailySalesInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetISR_DailySalesInvoice", new { id = iSR_DailySalesInvoice.ID }, iSR_DailySalesInvoice);
        }

        // DELETE: api/ISR_DailySalesInvoiceManual/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ISR_DailySalesInvoice>> DeleteISR_DailySalesInvoice(int id)
        {
            var iSR_DailySalesInvoice = await _context.ISR_Daily_Sales_Invoices.FindAsync(id);
            if (iSR_DailySalesInvoice == null)
            {
                return NotFound();
            }

            _context.ISR_Daily_Sales_Invoices.Remove(iSR_DailySalesInvoice);
            await _context.SaveChangesAsync();

            return iSR_DailySalesInvoice;
        }

        private bool ISR_DailySalesInvoiceExists(int id)
        {
            return _context.ISR_Daily_Sales_Invoices.Any(e => e.ID == id);
        }
    }
}
