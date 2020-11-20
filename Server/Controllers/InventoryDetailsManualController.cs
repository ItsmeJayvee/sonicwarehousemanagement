using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryDetailsManualController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InventoryDetailsManualController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InventoryDetailsManual
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryDetails>>> GetInventory_Details()
        {
            return await _context.Inventory_Details.ToListAsync();
        }

        // GET: api/InventoryDetailsManual/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryDetails>> GetInventoryDetails(int id)
        {
            var inventoryDetails = await _context.Inventory_Details.FindAsync(id);

            if (inventoryDetails == null)
            {
                return NotFound();
            }

            return inventoryDetails;
        }

        // GET: api/InventoryDetailsManual/getDetails/5
        [HttpGet("getDetails/{id}")]
        public async Task<ActionResult<InventoryDetails>> GetInventoryDetailsNew(string id)
        {
            var inventoryDetails = _context.Inventory_Details.Where(x => x.Header_Ref == id).ToList();

            if (inventoryDetails == null)
            {
                return NotFound();
            }

            return Ok(inventoryDetails);
        }

        // PUT: api/InventoryDetailsManual/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryDetails(int id, InventoryDetails inventoryDetails)
        {
            if (id != inventoryDetails.ID)
            {
                return BadRequest();
            }

            _context.Entry(inventoryDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoryDetailsExists(id))
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

        // POST: api/InventoryDetailsManual
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<InventoryDetails>> PostInventoryDetails(InventoryDetails inventoryDetails)
        {
            _context.Inventory_Details.Add(inventoryDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInventoryDetails", new { id = inventoryDetails.ID }, inventoryDetails);
        }

        // DELETE: api/InventoryDetailsManual/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InventoryDetails>> DeleteInventoryDetails(int id)
        {
            var inventoryDetails = await _context.Inventory_Details.FindAsync(id);
            if (inventoryDetails == null)
            {
                return NotFound();
            }

            _context.Inventory_Details.Remove(inventoryDetails);
            await _context.SaveChangesAsync();

            return inventoryDetails;
        }

        private bool InventoryDetailsExists(int id)
        {
            return _context.Inventory_Details.Any(e => e.ID == id);
        }
    }
}
