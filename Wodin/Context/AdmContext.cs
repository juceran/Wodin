using Microsoft.EntityFrameworkCore;
using Wodin.ContextFluentAPI;
using Wodin.Models;

namespace Wodin.Context
{
    public class AdmContext : DbContext
    {
        public AdmContext(DbContextOptions<AdmContext> options)
            : base(options)
        {
        }

        public DbSet<Empresa> Empresa { get; set; }        
        //menus para acesso ao site
        public DbSet<Menu> Menu { get; set; }
        public DbSet<SubMenu> SubMenu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new SubMenuConfiguration());
        }
    }
}
