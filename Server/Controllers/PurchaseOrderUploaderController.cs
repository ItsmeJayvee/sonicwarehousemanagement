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
    public class PurchaseOrderUploaderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchaseOrderUploaderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderUploader
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrder>>> GetPurchase_Orders()
        {
            return await _context.Purchase_Orders.ToListAsync();
        }
        [HttpGet("PurchaseDuplicateRows/{site}/{postDate}/{docDate}/{articleDoc}/{bilDoc}/{itemCode}/{qty}")]
        public async Task<ActionResult<PurchaseOrder>> PurchaseDuplicateRows(string site, DateTime postDate, DateTime docDate, string articleDoc, string bilDoc, string itemCode, int qty)
        {
            var purchase_order = _context.Purchase_Orders
                .Where(b => b.Site == site)
                .Where(b => b.Posting_Date == postDate)
                .Where(b => b.Document_Date == docDate)
                .Where(a => a.Article_Doc == articleDoc)
                .Where(g => g.Bill_Doc == bilDoc)
                .Where(g => g.Item_Code == itemCode)
                .Where(g => g.Quantity == qty).FirstOrDefault();

            if (purchase_order != null)
            {
                return Content("Duplicate");
            }
            else
            {
                return Content("awdawdaw");
            }

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
        // GET: api/PurchaseOrderUploader/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrder>> GetPurchaseOrder(int id)
        {
            var purchaseOrder = await _context.Purchase_Orders.FindAsync(id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return purchaseOrder;
        }

        // PUT: api/PurchaseOrderUploader/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrder(int id, PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.ID)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderExists(id))
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

        // POST: api/PurchaseOrderUploader
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PurchaseOrder>> PostPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _context.Purchase_Orders.Add(purchaseOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseOrder", new { id = purchaseOrder.ID }, purchaseOrder);
        }

        // DELETE: api/PurchaseOrderUploader/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseOrder>> DeletePurchaseOrder(int id)
        {
            var purchaseOrder = await _context.Purchase_Orders.FindAsync(id);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _context.Purchase_Orders.Remove(purchaseOrder);
            await _context.SaveChangesAsync();

            return purchaseOrder;
        }

        private bool PurchaseOrderExists(int id)
        {
            return _context.Purchase_Orders.Any(e => e.ID == id);
        }
    }
}
