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
    public class InventoryHeaderIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InventoryHeaderIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InventoryHeaderIndex
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

        // GET: api/InventoryHeaderIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryHeader>> GetInventoryHeader(string id)
        {
            var inventoryHeader = _context.Inventory_Headers.Where(x => x.Item_Code == id).Distinct().FirstOrDefault();

            if (inventoryHeader == null)
            {
                return NotFound();
            }

            return Ok(inventoryHeader);
        }

        // PUT: api/InventoryHeaderIndex/5
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

        // POST: api/InventoryHeaderIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("{itemcode}")]
        public async Task<ActionResult<InventoryHeader>> PostInventoryHeader(string itemcode, InventoryHeader inventoryHeader)
        {
            var items = _context.Inventory_Headers.Where(x => x.Item_Code == itemcode).Distinct().Count();

            if(items == 0)
            {
                _context.Inventory_Headers.Add(inventoryHeader);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetInventoryHeader", new { id = inventoryHeader.ID }, inventoryHeader);
            }

            return Ok("Item exist");
        }

        // DELETE: api/InventoryHeaderIndex/5
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
