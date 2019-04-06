using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {       
        public DbSet<Usuario> Usuarios { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new UsuarioConfiguration());
            /*model.Entity<Usuario>(entity=> {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Nome)
                    .HasColumnName("Nome")
                    .IsRequired()
                    .HasMaxLength(50);                
            });*/

                base.OnModelCreating(model);
        }

        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder
        //        .UseLazyLoadingProxies()
        //        .UseMySql(Configuration.GetConnectionString("DefaultConnection"),m=>m.MigrationsAssembly("Switch.Infra.Data"));
    }
}
