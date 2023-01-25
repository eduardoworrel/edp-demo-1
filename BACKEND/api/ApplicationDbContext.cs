using Microsoft.EntityFrameworkCore;
public class ApplicationDbContext: DbContext{
    public DbSet<Preferencias> Preferencias {get;set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options) {}
}