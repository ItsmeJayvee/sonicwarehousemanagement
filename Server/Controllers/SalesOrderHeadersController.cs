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
    public class SalesOrderHeadersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesOrderHeadersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrderHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderHeaders>>> GetSalesOrder_Headers()
        {
            return await _context.SalesOrder_Headers.ToListAsync();
        }

        // GET: api/SalesOrderHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderHeaders>> GetSalesOrderHeaders(int id)
        {
            var salesOrderHeaders = await _context.SalesOrder_Headers.FindAsync(id);

            if (salesOrderHeaders == null)
            {
                return NotFound();
            }

            return salesOrderHeaders;
        }
        [HttpGet("GetAllSalesOrder")]
        public async Task<ActionResult<SalesOrder>> GetAllInv()
        {

            var iSR_Daily_Sales_Invoice = await _context.Sales_Orders.Select(p => p.Order_Number).Distinct().ToListAsync();
            if (iSR_Daily_Sales_Invoice == null)
            {
                return NotFound();
            }

            return Ok(iSR_Daily_Sales_Invoice);
        }
        [HttpGet("GetAllOrderDup/{or_num}")]
        public async Task<ActionResult<SalesOrder>> InvoiceDuplicate(string or_num)
        {
            var sales_order = _context.Sales_Orders.Where(g => g.Order_Number == or_num).Select(p => new SalesOrder { Route_Type = p.Route_Type, Salesman_Name = p.Salesman_Name, Terms_of_payment = p.Terms_of_payment, Delivery_Free_Qty_CS = p.Delivery_Free_Qty_CS, Turnover_Value = p.Turnover_Value, Delivery_Free_Qty_PC = p.Delivery_Free_Qty_PC, Document_Category = p.Document_Category, Salesman = p.Salesman, Order_Type = p.Order_Type, Route_No = p.Route_No, Order_Type_Desc = p.Order_Type_Desc, Order_Number = p.Order_Number, SO_Date = p.SO_Date, Outlet_Code = p.Outlet_Code, Outlet_Name = p.Outlet_Name, Status = p.Status, Delivery_N = p.Delivery_N }).Distinct().FirstOrDefault();

            if (sales_order == null)
            {
                return NotFound();
            }

            return Ok(sales_order);
        }
        // PUT: api/SalesOrderHeaders/5
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

        // POST: api/SalesOrderHeaders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("{order_num}")]
        public async Task<ActionResult<SalesOrderHeaders>> PostSalesOrderHeaders(SalesOrderHeaders salesOrderHeaders, string order_num)
        {
            var salesorderHeader = _context.SalesOrder_Headers.Where(g => g.Order_Number == order_num).FirstOrDefault();

            if (salesorderHeader == null)
            {
                _context.SalesOrder_Headers.Add(salesOrderHeaders);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetSalesOrderHeaders", new { id = salesOrderHeaders.ID }, salesOrderHeaders);
            }
            else
            {
                return Ok("Duplicate");
            }

        }

        // DELETE: api/SalesOrderHeaders/5
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
