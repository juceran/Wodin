using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class PessoaFisicaConfiguration : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Fisica)
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
                .WithOne(p => p.PessoaFisica)
                .HasForeignKey<PessoaFisica>(p => p.PessoaId);

            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //    new PessoaFisica { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaId = 1, CPF = "75789515487",  RG = "1015915 SSP/AL", Sexo = Models.Enums.Sexo.Masculino, DataNascimento = DateTime.Parse("05/10/1972") },
            //    new PessoaFisica { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaId = 2, CPF = "",             RG = "",               Sexo = Models.Enums.Sexo.Masculino }
            //    );
        }
    }
}
