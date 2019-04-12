using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u=>u.Id);
            builder.Property(u => u.Nome).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Sexo).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Sobrenome).HasMaxLength(50).IsRequired();
            builder.Property(u => u.UrlFoto).HasMaxLength(200).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
            builder.HasOne(u => u.Identificacao)
                   .WithOne(i => i.Usuario)
                   .HasForeignKey<Identificacao>(i => i.UsuarioId);
            builder.HasMany(u => u.Postagens)
                .WithOne(p => p.Usuario);
        }
    }
}
