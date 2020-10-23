using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonicWarehouseManagement.Server.Data;
using SonicWarehouseManagement.Server.Helpers;
using SonicWarehouseManagement.Shared;

namespace SonicWarehouseManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessPartnersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BusinessPartnersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BusinessPartners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessPartner>>> GetBusiness_Partners([FromQuery] SalesInvoicePagination pagination)
        {
            var queryable = _context.Business_Partners.AsQueryable();
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/BusinessPartners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessPartner>> GetBusinessPartner(int id)
        {
            var businessPartner = await _context.Business_Partners.FindAsync(id);

            if (businessPartner == null)
            {
                return NotFound();
            }

            return businessPartner;
        }

        // PUT: api/BusinessPartners/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessPartner(int id, BusinessPartner businessPartner)
        {
            if (id != businessPartner.Id)
            {
                return BadRequest();
            }

            _context.Entry(businessPartner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessPartnerExists(id))
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

        // POST: api/BusinessPartners
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BusinessPartner>> PostBusinessPartner(BusinessPartner businessPartner)
        {
            _context.Business_Partners.Add(businessPartner);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinessPartner", new { id = businessPartner.Id }, businessPartner);
        }

        // DELETE: api/BusinessPartners/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BusinessPartner>> DeleteBusinessPartner(int id)
        {
            var businessPartner = await _context.Business_Partners.FindAsync(id);
            if (businessPartner == null)
            {
                return NotFound();
            }

            _context.Business_Partners.Remove(businessPartner);
            await _context.SaveChangesAsync();

            return businessPartner;
        }

        private bool BusinessPartnerExists(int id)
        {
            return _context.Business_Partners.Any(e => e.Id == id);
        }
    }
}
