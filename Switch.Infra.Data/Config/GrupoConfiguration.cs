using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public GrupoConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(P=>P.Id);
            builder.Property(g => g.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(g => g.Descricao)
                    .IsRequired()
                    .HasMaxLength(400);

            builder.HasMany(g => g.Postagens).WithOne(p => p.Grupo);
        }
    }
}
