﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class AmigoConfiguration : IEntityTypeConfiguration<Amigo>
    {
        public AmigoConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Amigo> builder)
        {
            builder.HasKey(a => new { a.UsuarioId, a.UsuarioAmigoId });
        }
    }
}
