using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderUploaderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesOrderUploaderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrderUploader
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrder>>> GetSales_Orders()
        {
            return await _context.Sales_Orders.ToListAsync();
        }

        // GET: api/SalesOrderUploader/5
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
        [HttpGet("GetPrev/{or_num}/{status}/{so_date}/{mat_n}/{pack_size}/{turn_over}")]
        public async Task<ActionResult<IEnumerable<SalesOrder>>> SalesOrderPrevent(string or_num, string status, DateTime so_date, string mat_n, string pack_size, decimal turn_over)
        {
            var sales_order = _context.Sales_Orders
              .Where(b => b.Order_Number == or_num)
              .Where(b => b.Status == status)
              .Where(b => b.SO_Date == so_date)
              .Where(b => b.Material_N == mat_n)
              .Where(b => b.Pack_Size == pack_size)
              .Where(b => b.Turnover_Value == turn_over).FirstOrDefault();


            if (sales_order == null)
            {
                return Ok("No Data");
            }
            else
            {
                return Ok("Duplicate");
            }


        }
        public async Task<string> DeleteDetails(string site, DateTime cal_day)
        {
            List<int> listOfHeader = new List<int>();
            var getHeaderIDs = await _context.SalesInvoice_Headers.Where(g => g.Calendar_Day == cal_day).Where(b => b.Site == site).Select(g => g.ID).ToListAsync();
            foreach (var getHead in getHeaderIDs)
            {
                listOfHeader.Add(getHead);
            }

            for (int x = 0; x < listOfHeader.Count(); x++)
            {
                var deleteDetails = _context.SalesInvoice_Details.Where(g => g.Header_ID == listOfHeader[x]).ToList();
                _context.SalesInvoice_Details.RemoveRange(deleteDetails);
                _context.SaveChanges();
            }
            return "Finished";
        }
        // PUT: api/SalesOrderUploader/5
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

        // POST: api/SalesOrderUploader
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesOrder>> PostSalesOrder(SalesOrder salesOrder)
        {
            _context.Sales_Orders.Add(salesOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrder", new { id = salesOrder.ID }, salesOrder);
        }

        // DELETE: api/SalesOrderUploader/5
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
