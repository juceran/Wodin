using Microsoft.EntityFrameworkCore;
using Wodin.Context;
using Wodin.Models;
using System.Linq;

namespace Wodin.Services
{
    public class SubMenuService
    {
        private readonly AdmContext _context;

        public SubMenuService(AdmContext context)
        {
            _context = context;
        }

        public bool SubMenuExiste(MenuLi menuLi)
        {
            var temp = _context.MenuLi.Where(d => d.SubMenu == menuLi.SubMenu).OrderBy(d => d.SubMenu);
            foreach (MenuLi item in temp)
            {
                if (item.SubMenu == menuLi.SubMenu)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
