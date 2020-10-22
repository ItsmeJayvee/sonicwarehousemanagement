using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Server.Helpers;
using SonicWarehouseManagement.Shared;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesInvoiceHeadersIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesInvoiceHeadersIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesInvoiceHeadersIndex
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesInvoice_Headers>>> GetSalesInvoice_Headers([FromQuery] SalesInvoicePagination pagination)
        {
            var queryable = _context.SalesInvoice_Headers.AsQueryable();
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/SalesInvoiceHeadersIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesInvoice_Headers>> GetSalesInvoice_Headers(int id)
        {
            var salesInvoice_Headers = await _context.SalesInvoice_Headers.FindAsync(id);

            if (salesInvoice_Headers == null)
            {
                return NotFound();
            }

            return salesInvoice_Headers;
        }

        // PUT: api/SalesInvoiceHeadersIndex/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesInvoice_Headers(int id, SalesInvoice_Headers salesInvoice_Headers)
        {
            if (id != salesInvoice_Headers.ID)
            {
                return BadRequest();
            }

            _context.Entry(salesInvoice_Headers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesInvoice_HeadersExists(id))
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

        // POST: api/SalesInvoiceHeadersIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesInvoice_Headers>> PostSalesInvoice_Headers(SalesInvoice_Headers salesInvoice_Headers)
        {
            _context.SalesInvoice_Headers.Add(salesInvoice_Headers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesInvoice_Headers", new { id = salesInvoice_Headers.ID }, salesInvoice_Headers);
        }

        // DELETE: api/SalesInvoiceHeadersIndex/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesInvoice_Headers>> DeleteSalesInvoice_Headers(int id)
        {
            var salesInvoice_Headers = await _context.SalesInvoice_Headers.FindAsync(id);
            if (salesInvoice_Headers == null)
            {
                return NotFound();
            }

            _context.SalesInvoice_Headers.Remove(salesInvoice_Headers);
            await _context.SaveChangesAsync();

            return salesInvoice_Headers;
        }

        private bool SalesInvoice_HeadersExists(int id)
        {
            return _context.SalesInvoice_Headers.Any(e => e.ID == id);
        }
    }
}
