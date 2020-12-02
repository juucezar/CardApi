using Microsoft.EntityFrameworkCore;

namespace CardAPI
{
    public class CardReceitContext : DbContext
    {
        public CardReceitContext(DbContextOptions<CardReceitContext> options)
         : base(options)
        {

        }

        public DbSet<CardReceit> CardReceit { get; set; }
    }
}

