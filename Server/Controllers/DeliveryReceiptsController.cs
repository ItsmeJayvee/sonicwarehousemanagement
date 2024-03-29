﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Server.Helpers;
using SonicWarehouseManagement.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryReceiptsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeliveryReceiptsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DeliveryReceipts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryReceipt>>> GetDelivery_Receipts([FromQuery] SalesInvoicePagination pagination, [FromQuery] string article)
        {
            var queryable = _context.Delivery_Receipts.AsQueryable();
            if (!string.IsNullOrEmpty(article))
            {
                queryable = queryable.Where(x => x.Delivery_Receipt_No.Contains(article));
            }
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/DeliveryReceipts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryReceipt>> GetDeliveryReceipt(int id)
        {
            var deliveryReceipt = await _context.Delivery_Receipts.FindAsync(id);

            if (deliveryReceipt == null)
            {
                return NotFound();
            }

            return deliveryReceipt;
        }

        // PUT: api/DeliveryReceipts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliveryReceipt(int id, DeliveryReceipt deliveryReceipt)
        {
            if (id != deliveryReceipt.ID)
            {
                return BadRequest();
            }

            _context.Entry(deliveryReceipt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryReceiptExists(id))
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

        // POST: api/DeliveryReceipts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DeliveryReceipt>> PostDeliveryReceipt(DeliveryReceipt deliveryReceipt)
        {
            _context.Delivery_Receipts.Add(deliveryReceipt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeliveryReceipt", new { id = deliveryReceipt.ID }, deliveryReceipt);
        }

        // DELETE: api/DeliveryReceipts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeliveryReceipt>> DeleteDeliveryReceipt(int id)
        {
            var deliveryReceipt = await _context.Delivery_Receipts.FindAsync(id);
            if (deliveryReceipt == null)
            {
                return NotFound();
            }

            _context.Delivery_Receipts.Remove(deliveryReceipt);
            await _context.SaveChangesAsync();

            return deliveryReceipt;
        }

        private bool DeliveryReceiptExists(int id)
        {
            return _context.Delivery_Receipts.Any(e => e.ID == id);
        }
    }
}
