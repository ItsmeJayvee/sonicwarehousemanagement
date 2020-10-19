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
    public class SalesInvoiceUploaderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesInvoiceUploaderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesInvoiceUploader
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ISR_DailySalesInvoice>>> GetISR_Daily_Sales_Invoices()
        {
            return await _context.ISR_Daily_Sales_Invoices.ToListAsync();
        }
        [HttpGet("GetPreventDuplicate/{site}/{cal_day}/{gsv}")]
        public async Task<ActionResult<IEnumerable<ISR_DailySalesInvoice>>> GetPreventDuplicate(string site, DateTime cal_day, decimal gsv)
        {

            decimal isr_Daily_Sales_Invoice = _context.ISR_Daily_Sales_Invoices
                                                    .Where(curSite => curSite.Site == site)
                                                    .Where(calendayDay => calendayDay.Calendar_Day == cal_day).Sum(b => b.GSV);
            if (isr_Daily_Sales_Invoice == 0)
            {
                return Ok("not found");
            }
            else
            {
                if (isr_Daily_Sales_Invoice == gsv)
                {
                    return Ok("Same");
                }
                else
                {
                    var deleteDaily = _context.ISR_Daily_Sales_Invoices
                                                    .Where(curSite => curSite.Site == site)
                                                    .Where(calendayDay => calendayDay.Calendar_Day == cal_day).ToList();
                    _context.ISR_Daily_Sales_Invoices.RemoveRange(deleteDaily);
                    _context.SaveChanges();

                    var detailsMSG = await DeleteDetails(site, cal_day);

                    if (detailsMSG == "Finished")
                    {
                        var deleteHeaders = _context.Invoice_Headers.Where(g => g.Calendar_Day == cal_day).Where(b => b.Site == site).ToList();
                        _context.Invoice_Headers.RemoveRange(deleteHeaders);
                        _context.SaveChanges();
                    }

                    return Ok("not same");
                }
            }

        }
        public async Task<string> DeleteDetails(string site, DateTime cal_day)
        {
            List<int> listOfHeader = new List<int>();
            var getHeaderIDs = await _context.Invoice_Headers.Where(g => g.Calendar_Day == cal_day).Where(b => b.Site == site).Select(g => g.ID).ToListAsync();
            foreach (var getHead in getHeaderIDs)
            {
                listOfHeader.Add(getHead);
            }

            for (int x = 0; x < listOfHeader.Count(); x++)
            {
                var deleteDetails = _context.Invoice_Details.Where(g => g.Header_ID == listOfHeader[x]).ToList();
                _context.Invoice_Details.RemoveRange(deleteDetails);
                _context.SaveChanges();
            }
            return "Finished";
        }
        // GET: api/SalesInvoiceUploader/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ISR_DailySalesInvoice>> GetISR_DailySalesInvoice(int id)
        {
            var iSR_DailySalesInvoice = await _context.ISR_Daily_Sales_Invoices.FindAsync(id);

            if (iSR_DailySalesInvoice == null)
            {
                return NotFound();
            }

            return iSR_DailySalesInvoice;
        }

        // PUT: api/SalesInvoiceUploader/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutISR_DailySalesInvoice(int id, ISR_DailySalesInvoice iSR_DailySalesInvoice)
        {
            if (id != iSR_DailySalesInvoice.ID)
            {
                return BadRequest();
            }

            _context.Entry(iSR_DailySalesInvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ISR_DailySalesInvoiceExists(id))
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

        // POST: api/SalesInvoiceUploader
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ISR_DailySalesInvoice>> PostISR_DailySalesInvoice(ISR_DailySalesInvoice iSR_DailySalesInvoice)
        {
            _context.ISR_Daily_Sales_Invoices.Add(iSR_DailySalesInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetISR_DailySalesInvoice", new { id = iSR_DailySalesInvoice.ID }, iSR_DailySalesInvoice);
        }

        // DELETE: api/SalesInvoiceUploader/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ISR_DailySalesInvoice>> DeleteISR_DailySalesInvoice(int id)
        {
            var iSR_DailySalesInvoice = await _context.ISR_Daily_Sales_Invoices.FindAsync(id);
            if (iSR_DailySalesInvoice == null)
            {
                return NotFound();
            }

            _context.ISR_Daily_Sales_Invoices.Remove(iSR_DailySalesInvoice);
            await _context.SaveChangesAsync();

            return iSR_DailySalesInvoice;
        }

        private bool ISR_DailySalesInvoiceExists(int id)
        {
            return _context.ISR_Daily_Sales_Invoices.Any(e => e.ID == id);
        }
    }
}
