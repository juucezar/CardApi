using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CardAPI;

namespace CardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardReceitController : ControllerBase
    {
        private readonly CardReceitContext _context;

        public CardReceitController(CardReceitContext context)
        {
            _context = context;
        }

        // GET: api/CardReceit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardReceit>>> GetCardReceit()
        {
            return await _context.CardReceit.ToListAsync();
        }

        // GET: api/CardReceit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardReceit>> GetCardReceit(int id)
        {
            var cardReceit = await _context.CardReceit.FindAsync(id);

            if (cardReceit == null)
            {
                return NotFound();
            }

            return cardReceit;
        }

        // PUT: api/CardReceit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardReceit(int id, CardReceit cardReceit)
        {
            if (id != cardReceit.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardReceit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardReceitExists(id))
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

        // POST: api/CardReceit
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CardReceit>> PostCardReceit(CardReceit cardReceit)
        {
            _context.CardReceit.Add(cardReceit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCardReceit", new { id = cardReceit.Id }, cardReceit);
        }

        // DELETE: api/CardReceit/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CardReceit>> DeleteCardReceit(int id)
        {
            var cardReceit = await _context.CardReceit.FindAsync(id);
            if (cardReceit == null)
            {
                return NotFound();
            }

            _context.CardReceit.Remove(cardReceit);
            await _context.SaveChangesAsync();

            return cardReceit;
        }

        private bool CardReceitExists(int id)
        {
            return _context.CardReceit.Any(e => e.Id == id);
        }
    }
}
