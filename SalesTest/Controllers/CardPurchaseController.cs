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
    public class CardPurchaseController : ControllerBase
    {
        private readonly CardPurchaseContext _context;

        public CardPurchaseController(CardPurchaseContext context)
        {
            _context = context;
        }

        // GET: api/CardPurchase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardPurchase>>> GetCardPurchase()
        {
            return await _context.CardPurchase.ToListAsync();
        }

        // GET: api/CardPurchase/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CardPurchase>> GetCardPurchase(int id)
        {
            var cardPurchase = await _context.CardPurchase.FindAsync(id);

            if (cardPurchase == null)
            {
                return NotFound();
            }

            return cardPurchase;
        }

        // PUT: api/CardPurchase/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCardPurchase(int id, CardPurchase cardPurchase)
        {
            if (id != cardPurchase.Id)
            {
                return BadRequest();
            }

            _context.Entry(cardPurchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardPurchaseExists(id))
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

        // POST: api/CardPurchase
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CardPurchase>> PostCardPurchase(CardPurchase cardPurchase)
        {
            _context.CardPurchase.Add(cardPurchase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCardPurchase", new { id = cardPurchase.Id }, cardPurchase);
        }

        // DELETE: api/CardPurchase/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CardPurchase>> DeleteCardPurchase(int id)
        {
            var cardPurchase = await _context.CardPurchase.FindAsync(id);
            if (cardPurchase == null)
            {
                return NotFound();
            }

            _context.CardPurchase.Remove(cardPurchase);
            await _context.SaveChangesAsync();

            return cardPurchase;
        }

        private bool CardPurchaseExists(int id)
        {
            return _context.CardPurchase.Any(e => e.Id == id);
        }
    }
}
