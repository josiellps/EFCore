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

        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public DbSet<LocalTrabalho> LocaisTrabalho { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new UsuarioConfiguration());
            model.ApplyConfiguration(new PostagemConfiguration());
            model.ApplyConfiguration(new GrupoConfiguration());
            model.ApplyConfiguration(new UsuarioGrupoConfiguration());

            model.ApplyConfiguration(new AmigoConfiguration());
            model.ApplyConfiguration(new ComentarioConfiguration());
            model.ApplyConfiguration(new StatusRelacionamentoConfiguration());
            model.ApplyConfiguration(new ProcurandoPorConfiguration());          

            base.OnModelCreating(model);
        }        
    }
}
