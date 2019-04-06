using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wodin.Migrations.Novo
{
    public partial class acessopermissao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_UsuarioPermissaoAcesso_UsuarioPermissaoAcessoId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_SubMenu_UsuarioPermissaoAcesso_UsuarioPermissaoAcessoId",
                table: "SubMenu");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermissaoAcesso_PessoaUsuario_PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropIndex(
                name: "IX_SubMenu_UsuarioPermissaoAcessoId",
                table: "SubMenu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_UsuarioPermissaoAcessoId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UsuarioPermissaoAcessoId",
                table: "SubMenu");

            migrationBuilder.DropColumn(
                name: "UsuarioPermissaoAcessoId",
                table: "Menu");

            migrationBuilder.RenameColumn(
                name: "PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso",
                newName: "SubmenuId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioPermissaoAcesso_PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso",
                newName: "IX_UsuarioPermissaoAcesso_SubmenuId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 192, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 192, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 692, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "UsuarioPermissaoAcesso",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "UsuarioPermissaoAcesso",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 176, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 675, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 176, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 675, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 191, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 191, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 691, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 189, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 689, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 189, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 689, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 188, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 687, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 188, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 687, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 186, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 686, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 186, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 686, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 184, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 684, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 184, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 684, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 181, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 680, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 181, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 680, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 182, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 682, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 182, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 682, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 179, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 678, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 178, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 678, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 177, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 676, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 177, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 676, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 174, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 674, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 174, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 674, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 171, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 670, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 169, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 669, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 173, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 673, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 173, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 672, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 14, 29, 52, 173, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 14, 29, 52, 171, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermissaoAcesso_MenuId",
                table: "UsuarioPermissaoAcesso",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermissaoAcesso_PessoaId",
                table: "UsuarioPermissaoAcesso",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermissaoAcesso_Menu_MenuId",
                table: "UsuarioPermissaoAcesso",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermissaoAcesso_Pessoa_PessoaId",
                table: "UsuarioPermissaoAcesso",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermissaoAcesso_SubMenu_SubmenuId",
                table: "UsuarioPermissaoAcesso",
                column: "SubmenuId",
                principalTable: "SubMenu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermissaoAcesso_Menu_MenuId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermissaoAcesso_Pessoa_PessoaId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioPermissaoAcesso_SubMenu_SubmenuId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioPermissaoAcesso_MenuId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioPermissaoAcesso_PessoaId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "UsuarioPermissaoAcesso");

            migrationBuilder.RenameColumn(
                name: "SubmenuId",
                table: "UsuarioPermissaoAcesso",
                newName: "PessoaUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioPermissaoAcesso_SubmenuId",
                table: "UsuarioPermissaoAcesso",
                newName: "IX_UsuarioPermissaoAcesso_PessoaUsuarioId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 192, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 192, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioPermissaoAcessoId",
                table: "SubMenu",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 675, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 176, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 675, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 176, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 191, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuarioSenha",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 691, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 191, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 689, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 189, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 689, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 189, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 687, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 188, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 687, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 188, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 686, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 186, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 686, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 186, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 684, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 184, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 684, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 184, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 680, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 181, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 680, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 181, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 682, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 182, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 682, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 182, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 678, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 179, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 678, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 178, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 676, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 177, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 676, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 177, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioPermissaoAcessoId",
                table: "Menu",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 674, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 174, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 674, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 174, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 670, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 171, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 669, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 169, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 673, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 173, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 4, 6, 13, 50, 31, 672, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 4, 6, 14, 29, 52, 173, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 13, 50, 31, 673, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 4, 6, 13, 50, 31, 671, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_SubMenu_UsuarioPermissaoAcessoId",
                table: "SubMenu",
                column: "UsuarioPermissaoAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_UsuarioPermissaoAcessoId",
                table: "Menu",
                column: "UsuarioPermissaoAcessoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_UsuarioPermissaoAcesso_UsuarioPermissaoAcessoId",
                table: "Menu",
                column: "UsuarioPermissaoAcessoId",
                principalTable: "UsuarioPermissaoAcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubMenu_UsuarioPermissaoAcesso_UsuarioPermissaoAcessoId",
                table: "SubMenu",
                column: "UsuarioPermissaoAcessoId",
                principalTable: "UsuarioPermissaoAcesso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioPermissaoAcesso_PessoaUsuario_PessoaUsuarioId",
                table: "UsuarioPermissaoAcesso",
                column: "PessoaUsuarioId",
                principalTable: "PessoaUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
