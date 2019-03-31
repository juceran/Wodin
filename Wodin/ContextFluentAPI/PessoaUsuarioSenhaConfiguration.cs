using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class PessoaUsuarioSenhaConfiguration : IEntityTypeConfiguration<PessoaUsuarioSenha>
    {
        public void Configure(EntityTypeBuilder<PessoaUsuarioSenha> modelBuilder)
        {
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
            //        new PessoaUsuarioSenha { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaUsuarioId = 1, Senha = "1" },
            //        new PessoaUsuarioSenha { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaUsuarioId = 2, Senha = "1" }
            //        );

        }
    }
}