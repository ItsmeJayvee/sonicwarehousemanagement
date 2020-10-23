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
    public class SalesOrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesOrdersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrder>>> GetSales_Orders([FromQuery] SalesInvoicePagination pagination)
        {
            var queryable = _context.Sales_Orders.AsQueryable();
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/SalesOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrder>> GetSalesOrder(int id)
        {
            var salesOrder = await _context.Sales_Orders.FindAsync(id);

            if (salesOrder == null)
            {
                return NotFound();
            }

            return salesOrder;
        }

        [HttpGet("GetAllSO")]
        public async Task<ActionResult<SalesOrder>> GetAllSalesOrder()
        {
            var salesOrder = await _context.Sales_Orders.Select(i => i.Order_Number).Distinct().ToListAsync();

            if (salesOrder == null)
            {
                return NotFound();
            }

            return Ok(salesOrder);
        }

        // PUT: api/SalesOrders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrder(int id, SalesOrder salesOrder)
        {
            if (id != salesOrder.ID)
            {
                return BadRequest();
            }

            _context.Entry(salesOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderExists(id))
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

        // POST: api/SalesOrders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesOrder>> PostSalesOrder(SalesOrder salesOrder)
        {
            _context.Sales_Orders.Add(salesOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrder", new { id = salesOrder.ID }, salesOrder);
        }

        // DELETE: api/SalesOrders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesOrder>> DeleteSalesOrder(int id)
        {
            var salesOrder = await _context.Sales_Orders.FindAsync(id);
            if (salesOrder == null)
            {
                return NotFound();
            }

            _context.Sales_Orders.Remove(salesOrder);
            await _context.SaveChangesAsync();

            return salesOrder;
        }

        private bool SalesOrderExists(int id)
        {
            return _context.Sales_Orders.Any(e => e.ID == id);
        }
    }
}
