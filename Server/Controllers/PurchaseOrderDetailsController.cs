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
    public class PurchaseOrderDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchaseOrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseDetails>>> GetPurchase_Details()
        {
            return await _context.Purchase_Details.ToListAsync();
        }
        [HttpGet("GetDuplicateOrder")]
        public async Task<ActionResult<PurchaseOrder>> GetDuplicateOrder()
        {

            var purchase_orders = await _context.Purchase_Orders.Select(p => new { p.Article_Doc, p.Bill_Doc }).Distinct().ToListAsync();
            if (purchase_orders == null)
            {
                return NotFound();
            }

            return Ok(purchase_orders);
        }
        [HttpGet("PurchaseCheckHeader/{article_Doc}/{bill_Doc}")]
        public async Task<ActionResult<PurchaseOrder>> PurchaseCheckHeader(string article_Doc, string bill_Doc)
        {
            var purchase_header = _context.Purchase_Headers.Where(g => g.Article_Doc == article_Doc).Where(g => g.Bill_Doc == bill_Doc).Select(p => p.ID).FirstOrDefault();
            if (purchase_header == 0)
            {
                return NotFound();
            }

            return Ok(purchase_header);
        }
        [HttpGet("PurchaseCheckDuplicate/{article_Doc}/{bill_Doc}")]
        public async Task<ActionResult<PurchaseOrder>> PurchaseCheckDuplicate(string article_Doc, string bill_Doc)
        {
            var purchase_order = _context.Purchase_Orders.Where(g => g.Article_Doc == article_Doc).Where(g => g.Bill_Doc == bill_Doc).Select(p => new { p.Site, p.Posting_Date, p.Document_Date, p.Item_Code, p.Item_Desc, p.Quantity }).ToList();
            if (purchase_order == null)
            {
                return NotFound();
            }

            return Ok(purchase_order);
        }
        [HttpGet("PurchaseDuplicateDetails/{article_Doc}/{bill_Doc}")]
        public async Task<ActionResult<PurchaseHeaders>> PurchaseDuplicateDetails(string article_Doc, string bill_Doc)
        {
            var purchaseDetails = _context.Purchase_Headers.Where(g => g.Article_Doc == article_Doc).Where(g => g.Bill_Doc == bill_Doc).Join(_context.Purchase_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Count();
            var purchaseOrder = _context.Purchase_Orders.Where(g => g.Article_Doc == article_Doc).Where(g => g.Bill_Doc == bill_Doc).Count();
            var invDetails = _context.Purchase_Headers.Where(g => g.Article_Doc == article_Doc).Where(g => g.Bill_Doc == bill_Doc).Join(_context.Purchase_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Select(b => b.det.Header_ID).FirstOrDefault();

            if (invDetails == 0)
            {
                return Ok("Okay");
            }
            else
            {
                if (purchaseDetails == purchaseOrder)
                {
                    return Ok("Duplicate");
                }
                else
                {
                    var deleteInvoiceDetails = _context.Purchase_Details.Where(g => g.Header_ID == invDetails).ToList();
                    _context.Purchase_Details.RemoveRange(deleteInvoiceDetails);
                    _context.SaveChanges();
                    return Ok("NotSame");
                }
            }
        }
        // GET: api/PurchaseOrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseDetails>> GetPurchaseDetails(int id)
        {
            var purchaseDetails = await _context.Purchase_Details.FindAsync(id);

            if (purchaseDetails == null)
            {
                return NotFound();
            }

            return purchaseDetails;
        }

        // PUT: api/PurchaseOrderDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseDetails(int id, PurchaseDetails purchaseDetails)
        {
            if (id != purchaseDetails.ID)
            {
                return BadRequest();
            }

            _context.Entry(purchaseDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseDetailsExists(id))
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

        // POST: api/PurchaseOrderDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PurchaseDetails>> PostPurchaseDetails(PurchaseDetails purchaseDetails)
        {
            _context.Purchase_Details.Add(purchaseDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseDetails", new { id = purchaseDetails.ID }, purchaseDetails);
        }

        // DELETE: api/PurchaseOrderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseDetails>> DeletePurchaseDetails(int id)
        {
            var purchaseDetails = await _context.Purchase_Details.FindAsync(id);
            if (purchaseDetails == null)
            {
                return NotFound();
            }

            _context.Purchase_Details.Remove(purchaseDetails);
            await _context.SaveChangesAsync();

            return purchaseDetails;
        }

        private bool PurchaseDetailsExists(int id)
        {
            return _context.Purchase_Details.Any(e => e.ID == id);
        }
    }
}
