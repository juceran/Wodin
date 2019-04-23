using System.Linq;
using Wodin.Context;
using Wodin.Models;

namespace Wodin.Services
{
    public class UsuarioPermissaoAcessoService
    {
        private readonly WodinContext _context;

        public UsuarioPermissaoAcessoService(WodinContext context)
        {
            _context = context;
        }
    }
}
