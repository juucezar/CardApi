using Microsoft.EntityFrameworkCore;

namespace CardAPI
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
          : base(options)
        {

        }
        public ClientContext() { }
        public DbSet<Client> Client { get; set; }
    }
}
