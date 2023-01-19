using Microsoft.EntityFrameworkCore;
using AussTennis.Models;

namespace AussTennis.Data
{
    public class AussTennisContext : DbContext
    {
        public AussTennisContext(DbContextOptions<AussTennisContext> options)
            : base(options)
        {

        }

        public DbSet<Player> Player { get; set; }

        public DbSet<AussTennis.Models.Customer> Customer { get; set; }

        public DbSet<AussTennis.Models.Organizer> Organizer { get; set; }

        public DbSet<AussTennis.Models.Registration> Registration { get; set; }

        public DbSet<AussTennis.Models.Tournament> Tournament { get; set; }
    }
}