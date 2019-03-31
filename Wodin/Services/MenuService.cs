using Wodin.Context;
using Wodin.Models;
using System.Linq;

namespace Wodin.Services
{
    public class MenuService
    {
        private readonly AdmContext _context;

        public MenuService(AdmContext context)
        {
            _context = context;
        }

        public bool MenuExiste(MenuUl menuUl)
        {
            var menu = _context.MenuUl.Where(d => d.Menu == menuUl.Menu).OrderBy(d => d.Menu);
            foreach (MenuUl item in menu)
            {
                if (item.Menu == menuUl.Menu)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
