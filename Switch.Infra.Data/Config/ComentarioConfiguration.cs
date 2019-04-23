using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public ComentarioConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(C => C.Id);

            builder.Property(c => c.DataPublicacao).IsRequired();
            builder.Property(c => c.Texto).IsRequired().HasMaxLength(600);
            builder.HasOne(c => c.Usuario).WithMany(u => u.Comentarios);

        }
    }
}
