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
    public class SalesOrderHeadersIndexController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesOrderHeadersIndexController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrderHeadersIndex
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderHeaders>>> GetSalesOrder_Headers([FromQuery] SalesInvoicePagination pagination, [FromQuery] string order)
        {
            var queryable = _context.SalesOrder_Headers.AsQueryable();
            if (!string.IsNullOrEmpty(order))
            {
                queryable = queryable.Where(x => x.Order_Number.Contains(order));
            }
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/SalesOrderHeadersIndex/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderHeaders>> GetSalesOrderHeaders(string id)
        {
            var salesOrderHeaders = _context.SalesOrder_Headers.Where(x => x.Order_Number == id).Distinct().FirstOrDefault();

            if(salesOrderHeaders == null)
            {
                return NotFound();
            }

            return Ok(salesOrderHeaders);
        }

        // PUT: api/SalesOrderHeadersIndex/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrderHeaders(int id, SalesOrderHeaders salesOrderHeaders)
        {
            if (id != salesOrderHeaders.ID)
            {
                return BadRequest();
            }

            _context.Entry(salesOrderHeaders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderHeadersExists(id))
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

        // POST: api/SalesOrderHeadersIndex
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesOrderHeaders>> PostSalesOrderHeaders(SalesOrderHeaders salesOrderHeaders)
        {
            _context.SalesOrder_Headers.Add(salesOrderHeaders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrderHeaders", new { id = salesOrderHeaders.ID }, salesOrderHeaders);
        }

        // DELETE: api/SalesOrderHeadersIndex/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesOrderHeaders>> DeleteSalesOrderHeaders(int id)
        {
            var salesOrderHeaders = await _context.SalesOrder_Headers.FindAsync(id);

            if (salesOrderHeaders == null)
            {
                return NotFound();
            }

            _context.SalesOrder_Headers.Remove(salesOrderHeaders);
            await _context.SaveChangesAsync();

            return salesOrderHeaders;
        }

        private bool SalesOrderHeadersExists(int id)
        {
            return _context.SalesOrder_Headers.Any(e => e.ID == id);
        }
    }
}
