using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Data.Mapping;

namespace Data.Context;

public class SqlServerContext : DbContext
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        { }

    public DbSet<Postagem>? Postagems {get;set;}
     protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Postagem>(new PostagemMap().Configure);
        }

}
