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
    public class SAPSalesmanMastersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SAPSalesmanMastersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SAPSalesmanMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SAPSalesmanMaster>>> GetSAP_SalesmanMasters()
        {
            return await _context.SAP_SalesmanMasters.ToListAsync();
        }

        // GET: api/SAPSalesmanMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SAPSalesmanMaster>> GetSAPSalesmanMaster(int id)
        {
            var sAPSalesmanMaster = (from emp in _context.SalesInvoice_Headers
                                     join us in _context.SAP_SalesmanMasters on emp.Salesman_Id equals us.Salesman_Code
                                     where emp.ID == id
                                     select new SAPSalesmanMaster { SalesLoc = us.SalesLoc, GiftLoc = us.GiftLoc, DamageLoc = us.DamageLoc }).FirstOrDefault();

            if (sAPSalesmanMaster == null)
            {
                return NotFound();
            }

            return Ok(sAPSalesmanMaster);
        }

        // PUT: api/SAPSalesmanMasters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSAPSalesmanMaster(int id, SAPSalesmanMaster sAPSalesmanMaster)
        {
            if (id != sAPSalesmanMaster.ID)
            {
                return BadRequest();
            }

            _context.Entry(sAPSalesmanMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SAPSalesmanMasterExists(id))
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

        // POST: api/SAPSalesmanMasters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SAPSalesmanMaster>> PostSAPSalesmanMaster(SAPSalesmanMaster sAPSalesmanMaster)
        {
            _context.SAP_SalesmanMasters.Add(sAPSalesmanMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSAPSalesmanMaster", new { id = sAPSalesmanMaster.ID }, sAPSalesmanMaster);
        }

        // DELETE: api/SAPSalesmanMasters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SAPSalesmanMaster>> DeleteSAPSalesmanMaster(int id)
        {
            var sAPSalesmanMaster = await _context.SAP_SalesmanMasters.FindAsync(id);
            if (sAPSalesmanMaster == null)
            {
                return NotFound();
            }

            _context.SAP_SalesmanMasters.Remove(sAPSalesmanMaster);
            await _context.SaveChangesAsync();

            return sAPSalesmanMaster;
        }

        private bool SAPSalesmanMasterExists(int id)
        {
            return _context.SAP_SalesmanMasters.Any(e => e.ID == id);
        }
    }
}
