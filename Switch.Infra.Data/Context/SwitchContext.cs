using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {       
        public DbSet<Usuario> Usuarios { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder
        //        .UseLazyLoadingProxies()
        //        .UseMySql(Configuration.GetConnectionString("DefaultConnection"),m=>m.MigrationsAssembly("Switch.Infra.Data"));
    }
}
