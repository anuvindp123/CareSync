using Microsoft.EntityFrameworkCore;

namespace WebAPI_Wa.Models
{
    public class Wa_DbContext : DbContext
    {
        public Wa_DbContext(DbContextOptions<Wa_DbContext> options) : base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
    }
}
