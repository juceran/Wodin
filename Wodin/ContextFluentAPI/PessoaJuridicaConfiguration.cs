using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class PessoaJuridicaConfiguration : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Juridica)
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
                .WithOne(p => p.PessoaJuridica)
                .HasForeignKey<PessoaJuridica>(p => p.PessoaId);

            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //        new PessoaJuridica { Id = 1, PessoaId = 1, CNPJ = "70000401000127", IE = "ISENTO", RazaoSocial = "JUCERAN CAVALCANTE ME", Fantasia = "CETASISTEMAS", Ativo = true, Deletado = false, DataAbertura = DateTime.Parse("18/01/1994"), DataCadastro = DateTime.Now, Juridica = true }
            //    );
        }
    }
}

