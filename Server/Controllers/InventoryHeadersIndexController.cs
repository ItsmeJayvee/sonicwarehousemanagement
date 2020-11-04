using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public class InventoryHeadersIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InventoryHeadersIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InventoryHeadersIndex
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryHeader>>> GetInventory_Headers([FromQuery] SalesInvoicePagination pagination, [FromQuery] string item)
        {
            var queryable = _context.Inventory_Headers.AsQueryable();
            if (!string.IsNullOrEmpty(item))
            {
                queryable = queryable.Where(x => x.Item_Code.Contains(item));
            }
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/InventoryHeadersIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryHeader>> GetInventoryHeader(int id)
        {
            var inventoryHeader = await _context.Inventory_Headers.FindAsync(id);

            if (inventoryHeader == null)
            {
                return NotFound();
            }

            return inventoryHeader;
        }

        // PUT: api/InventoryHeadersIndex/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryHeader(int id, InventoryHeader inventoryHeader)
        {
            if (id != inventoryHeader.ID)
            {
                return BadRequest();
            }

            _context.Entry(inventoryHeader).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryHeaderExists(id))
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

        // POST: api/InventoryHeadersIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("{id}")]
        public async Task<ActionResult<InventoryHeader>> PostInventoryHeader2(string id, InventoryHeader inventoryHeader)
        {
            var ids = _context.Inventory_Headers.Where(x => x.Item_Code == id).ToList();

            if(ids.Count == 0)
            {
                _context.Inventory_Headers.Add(inventoryHeader);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetInventoryHeader", new { id = inventoryHeader.ID }, inventoryHeader);
            }

            return Ok();
        }

        // DELETE: api/InventoryHeadersIndex/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InventoryHeader>> DeleteInventoryHeader(int id)
        {
            var inventoryHeader = await _context.Inventory_Headers.FindAsync(id);
            if (inventoryHeader == null)
            {
                return NotFound();
            }

            _context.Inventory_Headers.Remove(inventoryHeader);
            await _context.SaveChangesAsync();

            return inventoryHeader;
        }

        private bool InventoryHeaderExists(int id)
        {
            return _context.Inventory_Headers.Any(e => e.ID == id);
        }
    }
}
