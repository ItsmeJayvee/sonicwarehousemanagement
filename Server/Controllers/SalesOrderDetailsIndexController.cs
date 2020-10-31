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
    public class SalesOrderDetailsIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesOrderDetailsIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrderDetailsIndex
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderDetails>>> GetSalesOrder_Details()
        {
            return await _context.SalesOrder_Details.ToListAsync();
        }

        // GET: api/SalesOrderDetailsIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderDetails>> GetSalesOrderDetails(int id)
        {
            var salesOrderDetails = _context.SalesOrder_Details.Where(x => x.Header_ID == id).ToList();

            if (salesOrderDetails == null)
            {
                return NotFound();
            }

            return Ok(salesOrderDetails);
        }

        // PUT: api/SalesOrderDetailsIndex/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrderDetails(int id, SalesOrderDetails salesOrderDetails)
        {
            if (id != salesOrderDetails.ID)
            {
                return BadRequest();
            }

            _context.Entry(salesOrderDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderDetailsExists(id))
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

        // POST: api/SalesOrderDetailsIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("{id}")]
        public async Task<ActionResult<SalesOrderDetails>> PostSalesOrderDetails(int id, SalesOrderDetails salesOrderDetails)
        {
            var check = _context.SalesOrder_Details.Where(x => x.Header_ID == id).ToList();
            if(check == null)
            {
                return NotFound();
            }
            salesOrderDetails.Header_ID = id;
            _context.SalesOrder_Details.Add(salesOrderDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrderDetails", new { id = salesOrderDetails.ID }, salesOrderDetails);
        }

        // DELETE: api/SalesOrderDetailsIndex/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesOrderDetails>> DeleteSalesOrderDetails(int id)
        {
            var salesOrderDetails = await _context.SalesOrder_Details.FindAsync(id);
            if (salesOrderDetails == null)
            {
                return NotFound();
            }

            _context.SalesOrder_Details.Remove(salesOrderDetails);
            await _context.SaveChangesAsync();

            return salesOrderDetails;
        }

        private bool SalesOrderDetailsExists(int id)
        {
            return _context.SalesOrder_Details.Any(e => e.ID == id);
        }
    }
}
