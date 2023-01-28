using Microsoft.EntityFrameworkCore;

namespace Infra;
public class PreferenciasContext : DbContext
    {
        public DbSet<Preferencias> Preferencias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=easy;User Id=sa;Password=2f118668ce75448e9dc3a80e1621a968;TrustServerCertificate=true");
        }
    }