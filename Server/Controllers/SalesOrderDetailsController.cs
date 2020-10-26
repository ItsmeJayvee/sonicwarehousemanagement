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
    public class SalesOrderDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesOrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesOrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderDetails>>> GetSalesOrder_Details()
        {
            return await _context.SalesOrder_Details.ToListAsync();
        }
        [HttpGet("GetSalesDup")]
        public async Task<ActionResult<SalesOrder>> GetSalesOrderDup()
        {
            var sales_orders = await _context.Sales_Orders.Select(p => new { p.Order_Number }).Distinct().ToListAsync();

            if (sales_orders == null)
            {
                return NotFound();
            }

            return Ok(sales_orders);
        }
        [HttpGet("SalesCheckHeader/{order_num}")]
        public async Task<ActionResult<SalesOrder>> SalesCheckHeader(string order_num)
        {
            var salesorderHeaders = _context.SalesOrder_Headers.Where(g => g.Order_Number == order_num).Select(p => p.ID).FirstOrDefault();
            if (salesorderHeaders == 0)
            {
                return NotFound();
            }

            return Ok(salesorderHeaders);
        }
        [HttpGet("SalesCheckDuplicate/{order_num}")]
        public async Task<ActionResult<SalesOrder>> SalesCheckDuplicate(string order_num)
        {
            var sales_orders = _context.Sales_Orders.Where(g => g.Order_Number == order_num).Select(p => new SalesOrderDetails { Material_N = p.Material_N, Article_Description = p.Article_Description, Pack_Size = p.Pack_Size, Cases = p.Cases, Pieces = p.Pieces, Free_Cases = p.Free_Cases, Free_Piece = p.Free_Piece, Delivery_Qty_CS = p.Delivery_Qty_CS, Delivery_Qty_PC = p.Delivery_Qty_PC, Sales_Value = p.Sales_Value, VAT_Value = p.VAT_Value, Net_Sales = p.Net_Sales, Item_Number = p.Item_Number, Cases_Pieces = p.Cases_Pieces, Free_CS_PS = p.Free_CS_PS}).ToList();
            if (sales_orders == null)
            {
                return NotFound();
            }

            return Ok(sales_orders);
        }
        [HttpGet("SalesDuplicateDetails/{order_num}")]
        public async Task<ActionResult<SalesOrderHeaders>> SalesDuplicateDetails(string order_num)
        {
            var salesorderDetailsVal = _context.SalesOrder_Headers.Where(g => g.Order_Number == order_num).Join(_context.SalesOrder_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Sum(g => g.det.Sales_Value);
            var salesorderDetailsNet = _context.SalesOrder_Headers.Where(g => g.Order_Number == order_num).Join(_context.SalesOrder_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Sum(g => g.det.Net_Sales);
            var salesorderVal = _context.Sales_Orders.Where(b => b.Order_Number == order_num).Sum(g => g.Sales_Value);
            var salesorderNet = _context.Sales_Orders.Where(b => b.Order_Number == order_num).Sum(g => g.Net_Sales);
            var finalSetVal = salesorderDetailsVal + salesorderDetailsNet;
            var OrderSetVal = salesorderVal + salesorderNet;

            var salesDetails = _context.SalesOrder_Headers.Where(g => g.Order_Number == order_num).Join(_context.SalesOrder_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Select(b => b.det.Header_ID).FirstOrDefault();

            if (salesDetails == 0)
            {
                return Ok("Okay");
            }
            else
            {
                if (finalSetVal == OrderSetVal)
                {
                    return Ok("Duplicate");
                }
                else
                {
                    var deleteInvoiceDetails = _context.SalesOrder_Details.Where(g => g.Header_ID == salesDetails).ToList();
                    _context.SalesOrder_Details.RemoveRange(deleteInvoiceDetails);
                    _context.SaveChanges();
                    return Ok("NotSame");
                }
            }

        }
        // GET: api/SalesOrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderDetails>> GetSalesOrderDetails(int id)
        {
            var salesOrderDetails = await _context.SalesOrder_Details.FindAsync(id);

            if (salesOrderDetails == null)
            {
                return NotFound();
            }

            return salesOrderDetails;
        }

        // PUT: api/SalesOrderDetails/5
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

        // POST: api/SalesOrderDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesOrderDetails>> PostSalesOrderDetails(SalesOrderDetails salesOrderDetails)
        {
            _context.SalesOrder_Details.Add(salesOrderDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrderDetails", new { id = salesOrderDetails.ID }, salesOrderDetails);
        }

        // DELETE: api/SalesOrderDetails/5
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
