using Microsoft.EntityFrameworkCore;
namespace Data;
public class ApplicationDbContext: DbContext
{
    public DbSet<DadoGenerico>? DadoGenerico {get; set;}
    // repassando opções do .addContext para Class Pai
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    :base(options){}
}