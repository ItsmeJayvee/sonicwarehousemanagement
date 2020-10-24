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
    public class PurchaseHeadersIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchaseHeadersIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseHeadersIndex
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseHeaders>>> GetPurchase_Headers([FromQuery] SalesInvoicePagination pagination)
        {
            var queryable = _context.Purchase_Headers.AsQueryable();
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/PurchaseHeadersIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseHeaders>> GetPurchaseHeaders(int id)
        {
            var purchaseHeaders = await _context.Purchase_Headers.FindAsync(id);

            if (purchaseHeaders == null)
            {
                return NotFound();
            }

            return purchaseHeaders;
        }

        // PUT: api/PurchaseHeadersIndex/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseHeaders(int id, PurchaseHeaders purchaseHeaders)
        {
            if (id != purchaseHeaders.ID)
            {
                return BadRequest();
            }

            _context.Entry(purchaseHeaders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseHeadersExists(id))
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

        // POST: api/PurchaseHeadersIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PurchaseHeaders>> PostPurchaseHeaders(PurchaseHeaders purchaseHeaders)
        {
            _context.Purchase_Headers.Add(purchaseHeaders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseHeaders", new { id = purchaseHeaders.ID }, purchaseHeaders);
        }

        // DELETE: api/PurchaseHeadersIndex/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseHeaders>> DeletePurchaseHeaders(int id)
        {
            var purchaseHeaders = await _context.Purchase_Headers.FindAsync(id);
            if (purchaseHeaders == null)
            {
                return NotFound();
            }

            _context.Purchase_Headers.Remove(purchaseHeaders);
            await _context.SaveChangesAsync();

            return purchaseHeaders;
        }

        private bool PurchaseHeadersExists(int id)
        {
            return _context.Purchase_Headers.Any(e => e.ID == id);
        }
    }
}
