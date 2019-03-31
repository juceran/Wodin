using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class PessoaEmailConfiguration : IEntityTypeConfiguration<PessoaEmail>
    {
        public void Configure(EntityTypeBuilder<PessoaEmail> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Emails)
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

            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //        new PessoaEmail { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaId = 1, Email = "juceran@gmail.com", Tipo = Models.Enums.EmailTipo.pessoal         },
            //        new PessoaEmail { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaId = 2, Email = "diretoria@intimesoft.com.br", Tipo = Models.Enums.EmailTipo.comercial }
            //        );
        }
    }
}

