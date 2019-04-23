using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public StatusRelacionamentoConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(a => a.Id);
            builder.HasData(new StatusRelacionamento() { Id = 1, Descricao = "NaoEspecificado" });
            builder.HasData(new StatusRelacionamento() { Id = 2, Descricao = "Casado" });
            builder.HasData(new StatusRelacionamento() { Id = 3, Descricao = "RelacionamentoSerio" });
            builder.HasData(new StatusRelacionamento() { Id = 4, Descricao = "Solteiro" });
        }
    }
}
