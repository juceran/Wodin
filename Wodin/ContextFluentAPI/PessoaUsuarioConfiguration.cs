using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class PessoaUsuarioConfiguration : IEntityTypeConfiguration<PessoaUsuario>
    {
        public void Configure(EntityTypeBuilder<PessoaUsuario> modelBuilder)
        {
            modelBuilder
                .Property(p => p.User)
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
                .WithOne(p => p.PessoaUsuario)
                .HasForeignKey<PessoaUsuario>(p => p.PessoaId);
            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //    new PessoaUsuario { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, Usuario = "JUCERAN",      PessoaId = 1},
            //    new PessoaUsuario { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, Usuario = "JULIODEVELIS", PessoaId = 2}
            //    );
        }
    }
}
