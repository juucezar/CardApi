using Microsoft.EntityFrameworkCore;

namespace CardAPI
{
    public class CardPurchaseContext : DbContext
    {
        public CardPurchaseContext(DbContextOptions<CardPurchaseContext> options)
         : base(options)
        {

        }

        public DbSet<CardPurchase> CardPurchase { get; set; }
    }
}
