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
    public class SalesInvoiceHeadersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SalesInvoiceHeadersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesInvoiceHeaders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceHeaders>>> GetInvoice_Headers()
        {
            return await _context.Invoice_Headers.ToListAsync();
        }

        // GET: api/SalesInvoiceHeaders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceHeaders>> GetInvoiceHeaders(int id)
        {
            var invoiceHeaders = await _context.Invoice_Headers.FindAsync(id);

            if (invoiceHeaders == null)
            {
                return NotFound();
            }

            return invoiceHeaders;
        }
        [HttpGet("GetAllInv")]
        public async Task<ActionResult<ISR_DailySalesInvoice>> GetAllInv()
        {

            var iSR_Daily_Sales_Invoice = await _context.ISR_Daily_Sales_Invoices.Select(p => p.Invoice_No).Distinct().ToListAsync();
            if (iSR_Daily_Sales_Invoice == null)
            {
                return NotFound();
            }

            return Ok(iSR_Daily_Sales_Invoice);
        }
        [HttpGet("GetAllInvDup/{inv_no}")]
        public async Task<ActionResult<ISR_DailySalesInvoice>> InvoiceDuplicate(string inv_no)
        {
            var iSR_Daily_Sales_Invoice = _context.ISR_Daily_Sales_Invoices.Where(g => g.Invoice_No == inv_no).Select(p => new InvoiceHeaders { Distributor = p.Distributor, Distributor_Desc = p.Distributor_Desc, Site = p.Site, Site_Desc = p.Site_Desc, Sales_Route = p.Sales_Route, Route_Desc = p.Route_Desc, Outlet_Code = p.Outlet_Code, Outlet_Name = p.Outlet_Name, Master_FSS = p.Master_FSS, Master_FSS_Name = p.Master_FSS_Name, Salesman_Team_Type = p.Salesman_Team_Type, Salesman_Team_Type_Desc = p.Salesman_Team_Type_Desc, Calendar_Day = p.Calendar_Day, Invoice_Due_Date = p.Invoice_Due_Date, Purchase_Order_No = p.Purchase_Order_No, Sales_Order_No = p.Sales_Order_No, Invoice_No = p.Invoice_No, Billing_Type = p.Billing_Type, Billing_Type_1 = p.Billing_Type_1, Terms_Of_Payment = p.Terms_Of_Payment, Master_Outlet_Subtype = p.Master_Outlet_Subtype, Master_Outlet_Subtype_Name = p.Master_Outlet_Subtype_Name, Master_Outlet_City = p.Master_Outlet_City, Master_Outlet_City_Name = p.Master_Outlet_City_Name, Salesman_Id = p.Salesman_Id, Salesman_Name = p.Salesman_Name }).Distinct().FirstOrDefault();

            if (iSR_Daily_Sales_Invoice == null)
            {
                return NotFound();
            }

            return Ok(iSR_Daily_Sales_Invoice);
        }
        // PUT: api/SalesInvoiceHeaders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceHeaders(int id, InvoiceHeaders invoiceHeaders)
        {
            if (id != invoiceHeaders.ID)
            {
                return BadRequest();
            }

            _context.Entry(invoiceHeaders).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceHeadersExists(id))
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

        // POST: api/SalesInvoiceHeaders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("{invoice_no}")]
        public async Task<ActionResult<InvoiceHeaders>> PostInvoiceHeaders(InvoiceHeaders invoiceHeaders, string invoice_no)
        {
            var invoiceHeader = _context.Invoice_Headers.Where(g => g.Invoice_No == invoice_no).FirstOrDefault();

            if (invoiceHeader == null)
            {
                _context.Invoice_Headers.Add(invoiceHeaders);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetInvoiceHeaders", new { id = invoiceHeaders.ID }, invoiceHeaders);
            }
            else
            {
                return Ok("Duplicate");
            }
           
        }

        // DELETE: api/SalesInvoiceHeaders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<InvoiceHeaders>> DeleteInvoiceHeaders(int id)
        {
            var invoiceHeaders = await _context.Invoice_Headers.FindAsync(id);
            if (invoiceHeaders == null)
            {
                return NotFound();
            }

            _context.Invoice_Headers.Remove(invoiceHeaders);
            await _context.SaveChangesAsync();

            return invoiceHeaders;
        }

        private bool InvoiceHeadersExists(int id)
        {
            return _context.Invoice_Headers.Any(e => e.ID == id);
        }
    }
}
