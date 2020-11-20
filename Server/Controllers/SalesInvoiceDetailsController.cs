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
    public class SalesInvoiceDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesInvoiceDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesInvoiceDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesInvoice_Details>>> GetInvoice_Details()
        {
            return await _context.SalesInvoice_Details.ToListAsync();
        }

        // GET: api/SalesInvoiceDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesInvoice_Details>> GetInvoiceDetails(int id)
        {
            var invoiceDetails = await _context.SalesInvoice_Details.FindAsync(id);

            if (invoiceDetails == null)
            {
                return NotFound();
            }

            return invoiceDetails;
        }
        [HttpGet("GetAllDupDet")]
        public async Task<ActionResult<SalesInvoice>> GetDuplicateInvoiceDetails()
        {
            var iSR_Daily_Sales_Invoice = await _context.Sales_Invoice.Select(p => p.Invoice_No).Distinct().ToListAsync();
            if (iSR_Daily_Sales_Invoice == null)
            {
                return NotFound();
            }

            return Ok(iSR_Daily_Sales_Invoice);
        }
        [HttpGet("AllInvoiceDetails/{inv_no}")]
        public async Task<ActionResult<SalesInvoice>> AllInvoiceDetails(string inv_no)
        {
            var iSR_Daily_Sales_Invoice = _context.SalesInvoice_Headers.Where(g => g.Invoice_No == inv_no).Select(p => p.ID).FirstOrDefault();
            if (iSR_Daily_Sales_Invoice == 0)
            {
                return NotFound();
            }

            return Ok(iSR_Daily_Sales_Invoice);
        }
        [HttpGet("AllCheckDuplicate/{inv_no}")]
        public async Task<ActionResult<SalesInvoice>> AllCheckDuplicate(string inv_no)
        {
            var iSR_Daily_Sales_Invoice = _context.Sales_Invoice.Where(g => g.Invoice_No == inv_no).Select(p => new SalesInvoice_Details { Product_Id = p.Product_Id, Product_Name = p.Product_Name, Pack_Size = p.Pack_Size, Master_Brand = p.Master_Brand, Master_Brand_Name = p.Master_Brand_Name, Master_Basepack = p.Master_Basepack, Master_Basepack_Name = p.Master_Basepack_Name, Lead_Basepack = p.Lead_Basepack, Sales_Qty_CS = p.Sales_Qty_CS, Sales_Qty_PC = p.Sales_Qty_PC, Free_Qty_CS = p.Free_Qty_CS, Free_Qty_PC = p.Free_Qty_PC, Sales_Qty_Liter = p.Sales_Qty_Liter, Free_Qty_Liter = p.Free_Qty_Liter, Sales_Qty_Aggr_CS = p.Sales_Qty_Aggr_CS, Sales_Qty_Aggr_PC = p.Sales_Qty_Aggr_PC, Free_Qty_Aggr_CS = p.Free_Qty_Aggr_CS, Free_Qty_Aggr_PC = p.Free_Qty_Aggr_PC, GSV = p.GSV, TPR = p.TPR, UW = p.UW, DT_Discount = p.DT_Discount, Sales_After = p.Sales_After, Volume_Discount = p.Volume_Discount, Coupon_Discount = p.Coupon_Discount, NIV = p.NIV, VAT = p.VAT, Total_Sales_Amnt_Inc = p.Total_Sales_Amnt_Inc, Aggr_Pieces = p.Aggr_Pieces, Cabinet_Count = p.Cabinet_Count }).ToList();
            if (iSR_Daily_Sales_Invoice == null)
            {
                return NotFound();
            }

            return Ok(iSR_Daily_Sales_Invoice);
        }
        [HttpGet("CheckDuplicateDetails/{inv_no}")]
        public async Task<ActionResult<SalesInvoice_Details>> CheckDuplicateDetails(string inv_no)
        {
            var invoiceDetails = _context.SalesInvoice_Headers.Where(g => g.Invoice_No == inv_no).Join(_context.SalesInvoice_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Sum(g => g.det.GSV);
            var dailySalesInvoice = _context.Sales_Invoice.Where(b => b.Invoice_No == inv_no).Sum(g => g.GSV);
            var invDetails = _context.SalesInvoice_Headers.Where(g => g.Invoice_No == inv_no).Join(_context.SalesInvoice_Details, hed => hed.ID, det => det.Header_ID, (det, hed) => new { det = hed }).Select(b => b.det.Header_ID).FirstOrDefault();

            if (invDetails == 0)
            {
                return Ok("Okay");
            }
            else
            {
                if (invoiceDetails == dailySalesInvoice)
                {
                    return Ok("Duplicate");
                }
                else
                {
                    var deleteInvoiceDetails = _context.SalesInvoice_Details.Where(g => g.Header_ID == invDetails).ToList();
                    _context.SalesInvoice_Details.RemoveRange(deleteInvoiceDetails);
                    _context.SaveChanges();
                    return Ok("NotSame");
                }
            }


        }
        // PUT: api/SalesInvoiceDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceDetails(int id, SalesInvoice_Details invoiceDetails)
        {
            if (id != invoiceDetails.ID)
            {
                return BadRequest();
            }

            _context.Entry(invoiceDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceDetailsExists(id))
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

        // POST: api/SalesInvoiceDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesInvoice_Details>> PostInvoiceDetails(SalesInvoice_Details invoiceDetails)
        {
            _context.SalesInvoice_Details.Add(invoiceDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceDetails", new { id = invoiceDetails.ID }, invoiceDetails);
        }

        // DELETE: api/SalesInvoiceDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesInvoice_Details>> DeleteInvoiceDetails(int id)
        {
            var invoiceDetails = await _context.SalesInvoice_Details.FindAsync(id);
            if (invoiceDetails == null)
            {
                return NotFound();
            }

            _context.SalesInvoice_Details.Remove(invoiceDetails);
            await _context.SaveChangesAsync();

            return invoiceDetails;
        }

        private bool InvoiceDetailsExists(int id)
        {
            return _context.SalesInvoice_Details.Any(e => e.ID == id);
        }
    }
}
