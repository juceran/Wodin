﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Wodin.Context;

namespace Wodin.Migrations.Novo
{
    [DbContext(typeof(NovoContext))]
    [Migration("20190406165032_acesso")]
    partial class acesso
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Wodin.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 672, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 673, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Departamento");

                    b.HasData(
                        new { Id = 1, Ativo = true, DataCadastro = new DateTime(2019, 4, 6, 13, 50, 31, 673, DateTimeKind.Local), Deletado = false, EmpresaId = 1, Nome = "RECURSOS HUMANOS" }
                    );
                });

            modelBuilder.Entity("Wodin.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("DataAbertura")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 669, DateTimeKind.Local));

                    b.Property<string>("Database")
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Fantasia")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("GIA")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IBGE")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("IE")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Uf")
                        .IsRequired();

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 670, DateTimeKind.Local));

                    b.Property<string>("Unidade")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Website")
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");

                    b.HasData(
                        new { Id = 1, Ativo = true, Bairro = "TABULEIRO DO MARTINS", CEP = "57081000", CNPJ = "21373332000191", DataAbertura = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), DataCadastro = new DateTime(2019, 4, 6, 13, 50, 31, 671, DateTimeKind.Local), Database = "3R_Ambiental", Deletado = false, Email = "alexlamanda@gmail.com", Fantasia = "3R AMBIENTAL", IE = "", RazaoSocial = "3R INDÚSTRIA E COMÉRCIO DE PLÁSTICO LTDA - ME", Uf = "AL", Website = "" }
                    );
                });

            modelBuilder.Entity("Wodin.Models.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("BaixaLancamento")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("CartaoCredito")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("CartaoCreditoMelhorDia");

                    b.Property<int>("CartaoCreditoVencimento");

                    b.Property<int>("CartaoDeCredito");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 674, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("EmpresaId");

                    b.Property<int>("FormaPagamentoTipo");

                    b.Property<bool>("GeraFinanceiro")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 674, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("Wodin.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Controller")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime?>("DeletadoData");

                    b.Property<string>("Menus")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("UltimaAtualizacao");

                    b.Property<int?>("UsuarioPermissaoAcessoId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioPermissaoAcessoId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Wodin.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 676, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("EmpresaId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 676, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Wodin.Models.PessoaCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("Cliente")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 678, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("FormaRecebimentoId");

                    b.Property<decimal?>("LimiteCredito");

                    b.Property<int>("PessoaId");

                    b.Property<int>("PrazoRecebimentoId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 678, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("FormaRecebimentoId");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.HasIndex("PrazoRecebimentoId");

                    b.ToTable("PessoaCliente");
                });

            modelBuilder.Entity("Wodin.Models.PessoaEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 682, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("Emails")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaId");

                    b.Property<int>("Tipo");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 682, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaEmail");
                });

            modelBuilder.Entity("Wodin.Models.PessoaEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime?>("DeletadoData");

                    b.Property<bool>("Endereco");

                    b.Property<int>("EnderecoTipo");

                    b.Property<string>("GIA")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IBGE")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Localidade")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(64)");

                    b.Property<int>("PessoaId");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<DateTime?>("UltimaAtualizacao");

                    b.Property<string>("Unidade")
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaEndereco");
                });

            modelBuilder.Entity("Wodin.Models.PessoaFisica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(16)");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 680, DateTimeKind.Local));

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("Date");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<bool>("Fisica")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Mae")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Pai")
                        .HasColumnType("varchar(128)");

                    b.Property<int>("PessoaId");

                    b.Property<string>("RG")
                        .HasColumnType("varchar(64)");

                    b.Property<int?>("Sexo");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 680, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("PessoaFisica");
                });

            modelBuilder.Entity("Wodin.Models.PessoaFornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 684, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("FormaPagamentoId");

                    b.Property<bool>("Fornecedor")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaId");

                    b.Property<int>("PrazoPagamentoId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 684, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.HasIndex("PrazoPagamentoId");

                    b.ToTable("PessoaFornecedor");
                });

            modelBuilder.Entity("Wodin.Models.PessoaJuridica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Complemento");

                    b.Property<DateTime?>("DataAbertura")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 686, DateTimeKind.Local));

                    b.Property<DateTime?>("DataSituacao")
                        .HasColumnType("Date");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Fantasia")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IE")
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("Juridica")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("MotivoSituacao");

                    b.Property<int>("PessoaId");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Situacao")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 686, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("PessoaJuridica");
                });

            modelBuilder.Entity("Wodin.Models.PessoaTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 687, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<bool>("Fone")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaId");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<int>("Tipo");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 687, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaTelefone");
                });

            modelBuilder.Entity("Wodin.Models.PessoaUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 689, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("PessoaId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 689, DateTimeKind.Local));

                    b.Property<bool>("User")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Usuario")
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("PessoaUsuario");
                });

            modelBuilder.Entity("Wodin.Models.PessoaUsuarioSenha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 691, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("PessoaUsuarioId");

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 691, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaUsuarioId")
                        .IsUnique();

                    b.ToTable("PessoaUsuarioSenha");
                });

            modelBuilder.Entity("Wodin.Models.PrazoPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("BaixaLancamento");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 675, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("DiasParcela");

                    b.Property<int>("EmpresaId");

                    b.Property<decimal>("Limite");

                    b.Property<int>("Parcelas");

                    b.Property<decimal>("PrazoMedio");

                    b.Property<int>("PrazoPagamentoTipo");

                    b.Property<int>("PrimeiraParcela");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 675, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("PrazoPagamento");
                });

            modelBuilder.Entity("Wodin.Models.SubMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Controller")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime?>("DeletadoData");

                    b.Property<int>("MenuId");

                    b.Property<string>("SubMenus")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("UltimaAtualizacao");

                    b.Property<int?>("UsuarioPermissaoAcessoId");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("UsuarioPermissaoAcessoId");

                    b.ToTable("SubMenu");
                });

            modelBuilder.Entity("Wodin.Models.UsuarioPermissaoAcesso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("Baixar")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("Cancelar")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("CancelarBaixa")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 692, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<bool>("Editar")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("EmpresaId");

                    b.Property<bool>("Imprimir")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("Incluir")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaUsuarioId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 4, 6, 13, 50, 31, 692, DateTimeKind.Local));

                    b.Property<bool>("Visualizar")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("PessoaUsuarioId");

                    b.ToTable("UsuarioPermissaoAcesso");
                });

            modelBuilder.Entity("Wodin.Models.Departamento", b =>
                {
                    b.HasOne("Wodin.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.FormaPagamento", b =>
                {
                    b.HasOne("Wodin.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.Menu", b =>
                {
                    b.HasOne("Wodin.Models.UsuarioPermissaoAcesso")
                        .WithMany("Menu")
                        .HasForeignKey("UsuarioPermissaoAcessoId");
                });

            modelBuilder.Entity("Wodin.Models.Pessoa", b =>
                {
                    b.HasOne("Wodin.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaCliente", b =>
                {
                    b.HasOne("Wodin.Models.FormaPagamento", "FormaRecebimento")
                        .WithMany()
                        .HasForeignKey("FormaRecebimentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaCliente")
                        .HasForeignKey("Wodin.Models.PessoaCliente", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wodin.Models.PrazoPagamento", "PrazoRecebimento")
                        .WithMany()
                        .HasForeignKey("PrazoRecebimentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaEmail", b =>
                {
                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaEmail")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaEndereco", b =>
                {
                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaEndereco")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaFisica", b =>
                {
                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaFisica")
                        .HasForeignKey("Wodin.Models.PessoaFisica", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaFornecedor", b =>
                {
                    b.HasOne("Wodin.Models.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaFornecedor")
                        .HasForeignKey("Wodin.Models.PessoaFornecedor", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wodin.Models.PrazoPagamento", "PrazoPagamento")
                        .WithMany()
                        .HasForeignKey("PrazoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaJuridica", b =>
                {
                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaJuridica")
                        .HasForeignKey("Wodin.Models.PessoaJuridica", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaTelefone", b =>
                {
                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaTelefone")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaUsuario", b =>
                {
                    b.HasOne("Wodin.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaUsuario")
                        .HasForeignKey("Wodin.Models.PessoaUsuario", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PessoaUsuarioSenha", b =>
                {
                    b.HasOne("Wodin.Models.PessoaUsuario", "PessoaUsuario")
                        .WithOne("PessoaUsuarioSenha")
                        .HasForeignKey("Wodin.Models.PessoaUsuarioSenha", "PessoaUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.PrazoPagamento", b =>
                {
                    b.HasOne("Wodin.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wodin.Models.SubMenu", b =>
                {
                    b.HasOne("Wodin.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wodin.Models.UsuarioPermissaoAcesso")
                        .WithMany("SubMenu")
                        .HasForeignKey("UsuarioPermissaoAcessoId");
                });

            modelBuilder.Entity("Wodin.Models.UsuarioPermissaoAcesso", b =>
                {
                    b.HasOne("Wodin.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wodin.Models.PessoaUsuario", "PessoaUsuario")
                        .WithMany()
                        .HasForeignKey("PessoaUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
