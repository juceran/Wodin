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
        public DbSet<MenuUl> MenuUl { get; set; }
        public DbSet<MenuLi> MenuLi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());

            modelBuilder.ApplyConfiguration(new MenuUlConfiguration());
            modelBuilder.ApplyConfiguration(new MenuLiConfiguration());
        }
    }
}
