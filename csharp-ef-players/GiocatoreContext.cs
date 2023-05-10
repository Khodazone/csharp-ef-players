using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class GiocatoreContext : DbContext
    {
        public DbSet<Giocatore> Giocatore { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EfGiocatore;" +
                "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
