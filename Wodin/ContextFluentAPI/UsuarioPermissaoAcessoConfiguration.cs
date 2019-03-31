using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wodin.Models;
using System;

namespace Wodin.ContextFluentAPI
{
    public class UsuarioPermissaoAcessoConfiguration : IEntityTypeConfiguration<UsuarioPermissaoAcesso>
    {
        public void Configure(EntityTypeBuilder<UsuarioPermissaoAcesso> modelBuilder)
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

            //campos proprios
            modelBuilder
                .Property(p => p.Visualizar)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.Incluir)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.Editar)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.Imprimir)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.Baixar)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.Cancelar)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.CancelarBaixa)
                .HasDefaultValue(false);
        }
    }
}