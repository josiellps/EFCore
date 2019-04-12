using Microsoft.EntityFrameworkCore;
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
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Identificacao> Identificacao { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new UsuarioConfiguration());
            model.ApplyConfiguration(new PostagemConfiguration());
            model.ApplyConfiguration(new GrupoConfiguration());
            model.ApplyConfiguration(new UsuarioGrupoConfiguration());

            base.OnModelCreating(model);
        }        
    }
}
