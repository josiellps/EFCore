﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {       
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(model);
        }        
    }
}
