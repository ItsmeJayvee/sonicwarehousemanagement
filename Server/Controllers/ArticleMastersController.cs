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
    public class ArticleMastersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ArticleMastersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ArticleMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleMaster>>> GetArticle_Masters()
        {
            return await _context.Article_Masters.ToListAsync();
        }

        // GET: api/ArticleMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleMaster>> GetArticleMaster(int id)
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
