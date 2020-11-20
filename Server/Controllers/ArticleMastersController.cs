using Microsoft.AspNetCore.Http;
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
    public class ArticleMastersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ArticleMastersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ArticleMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleMaster>>> GetArticle_Masters([FromQuery] SalesInvoicePagination pagination, [FromQuery] string article)
        {
            var queryable = _context.Article_Masters.AsQueryable();
            if (!string.IsNullOrEmpty(article))
            {
                queryable = queryable.Where(x => x.Article_Code.Contains(article));
            }
            await HttpContext.InsertPaginationParameterResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        // GET: api/ArticleMasters/5
        [HttpGet("{searchitemnum}")]
        public async Task<ActionResult<ArticleMaster>> GetArticleMaster(string searchitemnum)
        {
            var articleMaster = _context.Article_Masters.Where(x => x.Article_Code == searchitemnum).Distinct().FirstOrDefault();

            if (articleMaster == null)
            {
                return NotFound();
            }

            return Ok(articleMaster);
        }

        // GET: api/ArticleMasters/5
        [HttpGet("item/{id}")]
        public async Task<ActionResult<ArticleMaster>> GetArticleMasterItem(int id)
        {
            var articleMaster = await _context.Article_Masters.FindAsync(id);

            if (articleMaster == null)
            {
                return NotFound();
            }

            return articleMaster;
        }

        // PUT: api/ArticleMasters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticleMaster(int id, ArticleMaster articleMaster)
        {
            if (id != articleMaster.id)
            {
                return BadRequest();
            }

            _context.Entry(articleMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleMasterExists(id))
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

        // POST: api/ArticleMasters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ArticleMaster>> PostArticleMaster(ArticleMaster articleMaster)
        {
            _context.Article_Masters.Add(articleMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticleMaster", new { id = articleMaster.id }, articleMaster);
        }

        // DELETE: api/ArticleMasters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ArticleMaster>> DeleteArticleMaster(int id)
        {
            var articleMaster = await _context.Article_Masters.FindAsync(id);
            if (articleMaster == null)
            {
                return NotFound();
            }

            _context.Article_Masters.Remove(articleMaster);
            await _context.SaveChangesAsync();

            return articleMaster;
        }

        private bool ArticleMasterExists(int id)
        {
            return _context.Article_Masters.Any(e => e.id == id);
        }
    }
}
