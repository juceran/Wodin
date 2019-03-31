using Wodin.Context;
using Wodin.Models;
using System.Linq;

namespace Wodin.Services
{
    public class DepartamentoService
    {
        private readonly WodinContext _context;

        public DepartamentoService(WodinContext context)
        {
            _context = context;
        }

        public bool DepartamentoExiste(Departamento departamento)
        {
            var dptos = _context.Departamento.Where(d => d.EmpresaId == departamento.EmpresaId).OrderBy(d => d.Nome);
            foreach (Departamento item in dptos)
            {
                if (item.Nome == departamento.Nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
