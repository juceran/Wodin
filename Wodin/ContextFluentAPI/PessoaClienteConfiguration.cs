using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class PessoaClienteConfiguration : IEntityTypeConfiguration<PessoaCliente>
    {
        public void Configure(EntityTypeBuilder<PessoaCliente> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Cliente)
                .HasDefaultValue(false);
            //campos comuns
            modelBuilder
                .Property(p => p.Ativo)
                .HasDefaultValue(true);
            modelBuilder
                .Property(p => p.Deletado)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.DataCadastro)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValue(DateTime.Now);
            modelBuilder
                .Property(p => p.UltimaAtualizacao)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValue(DateTime.Now);
            modelBuilder
                .Property(p => p.DeletadoData)
                .HasColumnType("TIMESTAMP");

            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(p => p.PessoaCliente)
                .HasForeignKey<PessoaCliente>(p => p.PessoaId);

            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //    new PessoaCliente { Id = 1, PessoaId = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, Cliente = true, LimiteCredito = 500 },
            //    new PessoaCliente { Id = 2, PessoaId = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, Cliente = true, LimiteCredito = 500 }
            //    );
        }
    }
}

