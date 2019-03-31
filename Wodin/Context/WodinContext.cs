using Microsoft.EntityFrameworkCore;
using Wodin.ContextFluentAPI;
using Wodin.Models;

namespace Wodin.Context
{
    public class WodinContext : DbContext
    {
        public WodinContext(DbContextOptions<WodinContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (Program.BancoDeDadosAplicacao != null)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=" + Program.BancoDeDadosAplicacao + ";Username=WODINPASS;Password=(*5523bASS%$12_.");
            }
        }

        //tabelas que serão incluídas no banco de dados
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<PrazoPagamento> PrazoPagamento { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaCliente> PessoaCliente { get; set; }
        public DbSet<PessoaEmail> PessoaEmail { get; set; }
        public DbSet<PessoaEndereco> PessoaEndereco { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaFornecedor> PessoaFornecedor { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<PessoaTelefone> PessoaTelefone { get; set; }
        public DbSet<PessoaUsuario> PessoaUsuario { get; set; }
        public DbSet<PessoaUsuarioSenha> PessoaUsuarioSenha { get; set; }

        public DbSet<UsuarioPermissaoAcesso> UsuarioPermissaoAcesso { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
            modelBuilder.ApplyConfiguration(new DepartamentoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new PrazoPagamentoConfiguration());

            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaClienteConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaFisicaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaEmailConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaFornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaTelefoneConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaUsuarioSenhaConfiguration());

            modelBuilder.ApplyConfiguration(new UsuarioPermissaoAcessoConfiguration());
        }
    }
}