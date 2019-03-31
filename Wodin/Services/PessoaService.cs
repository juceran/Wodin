using Wodin.Context;
using Wodin.Models;
using System.Linq;

namespace Wodin.Services
{
    public class PessoaService
    {
        private readonly WodinContext _context;

        public PessoaService(WodinContext context)
        {
            _context = context;
        }

        public bool ValidarPessoaUsuario(Pessoa pessoa)
        {
            //valida USUARIO
            if (pessoa.PessoaUsuario.User == true)
            {
                IQueryable<Pessoa> x = _context.Pessoa
                    .Where(p => p.EmpresaId == pessoa.EmpresaId)
                    .Where(p => p.PessoaUsuario.Usuario == pessoa.PessoaUsuario.Usuario && p.PessoaUsuario.Ativo == true);
                if(x.GetEnumerator().MoveNext() == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}