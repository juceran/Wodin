using System.Linq;
using Wodin.Context;
using Wodin.Models;

namespace Wodin.Services
{
    public class SubMenuService
    {
        private readonly AdmContext _context;

        public SubMenuService(AdmContext context)
        {
            _context = context;
        }

        public bool SubMenuExiste(SubMenu submenu)
        {
            var temp = _context.SubMenu.Where(d => d.SubMenus == submenu.SubMenus).OrderBy(d => d.SubMenus);
            foreach (SubMenu item in temp)
            {
                if (item.SubMenus == submenu.SubMenus)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
