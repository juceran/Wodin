using System.Linq;
using System.Security.Cryptography;
using Wodin.Comuns;
using Wodin.Context;
using Wodin.Models;

namespace Wodin.Services
{
    public class LoginService
    {
        private readonly AdmContext _context;
        private readonly WodinContext _contextAplicacao;

        public LoginService(AdmContext context, WodinContext contextAplicacao)
        {
            _context = context;
            _contextAplicacao = contextAplicacao;
        }

        public Pessoa PessoaLogada { get; set; }

        public bool ValidarAcesso(Login login)
        {
            //Remover caracteres do CPForCNPJ
            string CNPJ = RemoverCaracteres.StringSemFormatacao(login.CNPJ);

            //testar se a empresa existe no banco administrativo caso verdadeiro seleciona o banco de dados para aplicação
            IQueryable<Empresa> empresaAdm = _context.Empresa
                .Where(e => e.CNPJ == CNPJ)
                .Where(e => e.Ativo == true);

            string database = "";
            foreach (Empresa p in empresaAdm)
            {
                database = p.Database;
            }

            if (!string.IsNullOrEmpty(database))
            {
                //altera o direcionamento da base de dados do contexto
                Program.BancoDeDadosAplicacao = database;

                //verifica se a empresa existe na base aplicação e resgata as informações
                IQueryable<Empresa> empresaAplicacao = _contextAplicacao.Empresa
                    .Where(e => e.CNPJ == CNPJ)
                    .Where(e => e.Database == database)
                    .Where(x => x.Ativo == true);

                foreach (Empresa item in empresaAplicacao)
                {
                    Program.EmpresaId = item.Id;
                }

                //Codifica a senha para ficar igual ao banco de dados
                login.Senha = CodificarString.RetornarMD5(login.Senha);
                
                //verifica o acesso do usuario
                IQueryable<Pessoa> acesso = _contextAplicacao.Pessoa
                    .Where(p => p.PessoaUsuario.Usuario == login.Usuario)
                    .Where(p => p.PessoaUsuario.PessoaUsuarioSenha.Senha == login.Senha && p.PessoaUsuario.PessoaUsuarioSenha.Ativo == true)
                    .Where(p => p.Deletado == false)
                    .Where(p => p.EmpresaId == Program.EmpresaId);
                if (acesso.GetEnumerator().MoveNext() == true)
                {
                    foreach (var item in acesso)
                    {
                        //implementar as permissões do usuario
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
