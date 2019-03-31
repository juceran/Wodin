using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Context;
using Wodin.Models;
using Wodin.Services;

namespace Wodin.Controllers
{
    public class MenuLisController : Controller
    {
        private readonly AdmContext _context;
        private readonly SubMenuService _submenuService;

        public MenuLisController(AdmContext context, SubMenuService submenuService)
        {
            _context = context;
            _submenuService = submenuService;
        }

        // GET: MenuLis
        public async Task<IActionResult> Index(int filtroMenu, string filtro)
        {
            ViewData["filtro"] = filtro;
            ViewData["filtroMenu"] = filtroMenu;
            var salesWebMvcContext = _context.MenuLi.Include(m => m.MenuUl).OrderBy(sm => sm.SubMenu);
            ViewData["MenuUlId"] = new SelectList(_context.MenuUl.OrderBy(x => x.Menu), "Id", "Menu");
            ViewBag.filtroMenu = new SelectList(_context.MenuUl.OrderBy(x => x.Menu), "Id", "Menu");

            if (!String.IsNullOrEmpty(filtro) || filtroMenu != 0 )
            {
                if(filtro == null) { filtro = ""; }
                //filtra por submenu
                return View(await _context.MenuLi
                                    .OrderBy(x => x.SubMenu)
                                    .Where(x => x.MenuUlId == filtroMenu)
                                    .Where(x => x.SubMenu.Contains(filtro))
                                    .ToListAsync());
            }
            else
            {
                return View(await salesWebMvcContext.OrderBy(x => x.SubMenu).ToListAsync());
            } 
        }

        // GET: MenuLis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuLi = await _context.MenuLi
                .Include(m => m.MenuUl)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuLi == null)
            {
                return NotFound();
            }

            return View(menuLi);
        }

        // GET: MenuLis/Create
        public IActionResult Create()
        {
            ViewData["MenuUlId"] = new SelectList(_context.MenuUl.OrderBy(x => x.Menu), "Id", "Menu");
            return View();
        }

        // POST: MenuLis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubMenu,Url,Titulo,MenuUlId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] MenuLi menuLi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(menuLi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuUlId"] = new SelectList(_context.MenuUl.OrderBy(x => x.Menu), "Id", "Menu", menuLi.MenuUlId);
            return View(menuLi);
        }

        // GET: MenuLis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuLi = await _context.MenuLi.FindAsync(id);
            if (menuLi == null)
            {
                return NotFound();
            }
            ViewData["MenuUlId"] = new SelectList(_context.MenuUl.OrderBy(x => x.Menu), "Id", "Menu", menuLi.MenuUlId);
            return View(menuLi);
        }

        // POST: MenuLis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubMenu,Url,Titulo,MenuUlId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] MenuLi menuLi)
        {
            if (id != menuLi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menuLi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuLiExists(menuLi.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuUlId"] = new SelectList(_context.MenuUl.OrderBy(x => x.Menu), "Id", "Menu", menuLi.MenuUlId);
            return View(menuLi);
        }

        // GET: MenuLis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuLi = await _context.MenuLi
                .Include(m => m.MenuUl)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuLi == null)
            {
                return NotFound();
            }

            return View(menuLi);
        }

        // POST: MenuLis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menuLi = await _context.MenuLi.FindAsync(id);
            menuLi.Ativo = false;
            menuLi.Deletado = true;
            menuLi.DeletadoData = DateTime.Now;
            _context.MenuLi.Update(menuLi);
            //_context.MenuLi.Remove(menuLi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuLiExists(int id)
        {
            return _context.MenuLi.Any(e => e.Id == id);
        }
    }
}
