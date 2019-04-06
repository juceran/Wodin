using System.Linq;
using Wodin.Context;
using Wodin.Models;

namespace Wodin.Services
{
    public class UsuarioPermissaoAcesso
    {
        private readonly WodinContext _context;

        public UsuarioPermissaoAcesso(WodinContext context)
        {
            _context = context;
        }

    }
}
