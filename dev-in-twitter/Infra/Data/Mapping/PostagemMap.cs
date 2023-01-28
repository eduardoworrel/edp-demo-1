using System.Collections.Immutable;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping;

public class PostagemMap : IEntityTypeConfiguration<Postagem>
{
    public void Configure(EntityTypeBuilder<Postagem> builder)
    {
        builder.ToTable("Postagems");

        builder.HasKey(p=>p.Id);


        builder.Property(p => p.NomeUsuario)
        .IsRequired()
        .HasColumnType("varchar(60)");

        builder.Property(p => p.ConteudoPublicado)
        .IsRequired()
        .HasColumnType("varchar(140)");


        builder.Property(p => p.DataHoraPublicacao)
        .IsRequired()
        .HasColumnType("datetime");


        
    }
}
