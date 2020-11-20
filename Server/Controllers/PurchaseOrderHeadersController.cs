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
    public class PurchaseOrderHeadersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchaseOrderHeadersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseHeaders>>> GetPurchase_Headers()
        {
            return await _context.Purchase_Headers.ToListAsync();
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
        [HttpGet("PurchaseDuplicate/{articleDoc}/{bilDoc}")]
        public async Task<ActionResult<PurchaseOrder>> PurchaseDuplicate(string articleDoc, string bilDoc)
        {
            var purchaseOrder = _context.Purchase_Orders.Where(g => g.Article_Doc == articleDoc).Where(g => g.Bill_Doc == bilDoc).Select(p => new PurchaseOrder { Article_Doc = p.Article_Doc, Bill_Doc = p.Bill_Doc }).Distinct().FirstOrDefault();

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return Ok(purchaseOrder);
        }
        // GET: api/PurchaseOrderHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseHeaders>> GetPurchaseHeaders(int id)
        {
            var purchaseHeaders = await _context.Purchase_Headers.FindAsync(id);

            if (purchaseHeaders == null)
            {
                return NotFound();
            }

            return purchaseHeaders;
        }

        // PUT: api/PurchaseOrderHeaders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseHeaders(int id, PurchaseHeaders purchaseHeaders)
        {
            if (id != purchaseHeaders.ID)
            {
                return BadRequest();
            }

            _context.Entry(purchaseHeaders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseHeadersExists(id))
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

        // POST: api/PurchaseOrderHeaders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        /*[HttpPost]
        public async Task<ActionResult<PurchaseHeaders>> PostPurchaseHeaders(PurchaseHeaders purchaseHeaders)
        {
            _context.Purchase_Headers.Add(purchaseHeaders);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPurchaseHeaders", new { id = purchaseHeaders.ID }, purchaseHeaders);
        }*/
        [HttpPost("{article_Doc}/{bill_Doc}")]
        public async Task<ActionResult<PurchaseHeaders>> PostPurchaseHeaders(PurchaseHeaders purchase_Headers, string article_Doc, string bill_Doc)
        {
            var purchaseHeader = _context.Purchase_Headers.Where(g => g.Article_Doc == article_Doc).Where(g => g.Bill_Doc == bill_Doc).FirstOrDefault();
            if (purchaseHeader == null)
            {
                _context.Purchase_Headers.Add(purchase_Headers);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetPurchase_Headers", new { id = purchase_Headers.ID }, purchaseHeader);
            }
            else
            {
                return Ok("Duplicate");
            }

        }
        // DELETE: api/PurchaseOrderHeaders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PurchaseHeaders>> DeletePurchaseHeaders(int id)
        {
            var purchaseHeaders = await _context.Purchase_Headers.FindAsync(id);
            if (purchaseHeaders == null)
            {
                return NotFound();
            }

            _context.Purchase_Headers.Remove(purchaseHeaders);
            await _context.SaveChangesAsync();

            return purchaseHeaders;
        }

        private bool PurchaseHeadersExists(int id)
        {
            return _context.Purchase_Headers.Any(e => e.ID == id);
        }
    }
}
