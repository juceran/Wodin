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

        public bool MenuExiste(Menu menu)
        {
            var x = _context.Menu.Where(d => d.Menus == menu.Menus).OrderBy(d => d.Menus);
            foreach (Menu item in x)
            {
                if (item.Menus == menu.Menus)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
