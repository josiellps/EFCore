using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class ProcurandoPorConfiguration : IEntityTypeConfiguration<ProcurandoPor>
    {
        public ProcurandoPorConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<ProcurandoPor> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasData(new ProcurandoPor() { Id = 1, Descricao = "NaoEspecificado" });
            builder.HasData(new ProcurandoPor() { Id = 2, Descricao = "Namoro" });
            builder.HasData(new ProcurandoPor() { Id = 3, Descricao = "Amizade" });
            builder.HasData(new ProcurandoPor() { Id = 4, Descricao = "RelacionamentoSerio" });
        }
    }
}
