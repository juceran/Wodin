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
    public class SubMenusController : Controller
    {
        private readonly AdmContext _context;
        private readonly SubMenuService _submenuService;

        public SubMenusController(AdmContext context, SubMenuService submenuService)
        {
            _context = context;
            _submenuService = submenuService;
        }

        // GET: SubMenus
        public async Task<IActionResult> Index(int filtroMenu, string filtro)
        {
            ViewData["filtro"] = filtro;
            ViewData["filtroMenu"] = filtroMenu;
            var dados = _context.SubMenu.Include(m => m.Menu).OrderBy(sm => sm.SubMenus);
            ViewData["MenuId"] = new SelectList(_context.Menu.OrderBy(m => m.Menus), "Id", "Menus");
            ViewBag.filtroMenu = new SelectList(_context.Menu.OrderBy(m => m.Menus), "Id", "Menus");

            if(!String.IsNullOrEmpty(filtro) || filtroMenu != 0)
            {
                if (filtro == null) { filtro = ""; }
                //filtra por submenu
                return View(await _context.SubMenu
                    .OrderBy(sm => sm.SubMenus)
                    .Where(sm => sm.MenuId == filtroMenu)
                    .Where(sm => sm.SubMenus.Contains(filtro))
                    .ToListAsync()
                    );
            }
            else
            {
                return View(await dados.ToListAsync());
            }          
        }

        // GET: SubMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subMenu = await _context.SubMenu
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subMenu == null)
            {
                return NotFound();
            }

            return View(subMenu);
        }

        // GET: SubMenus/Create
        public IActionResult Create()
        {
            ViewData["MenuId"] = new SelectList(_context.Menu, "Id", "Menus");
            return View();
        }

        // POST: SubMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubMenus,Controller,Titulo,MenuId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] SubMenu subMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuId"] = new SelectList(_context.Menu, "Id", "Menus", subMenu.MenuId);
            return View(subMenu);
        }

        // GET: SubMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subMenu = await _context.SubMenu.FindAsync(id);
            if (subMenu == null)
            {
                return NotFound();
            }
            ViewData["MenuId"] = new SelectList(_context.Menu, "Id", "Menus", subMenu.MenuId);
            return View(subMenu);
        }

        // POST: SubMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubMenus,Controller,Titulo,MenuId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] SubMenu subMenu)
        {
            if (id != subMenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubMenuExists(subMenu.Id))
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
            ViewData["MenuId"] = new SelectList(_context.Menu, "Id", "Id", subMenu.MenuId);
            return View(subMenu);
        }

        // GET: SubMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subMenu = await _context.SubMenu
                .Include(s => s.Menu)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subMenu == null)
            {
                return NotFound();
            }

            return View(subMenu);
        }

        // POST: SubMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subMenu = await _context.SubMenu.FindAsync(id);
            subMenu.Ativo = false;
            subMenu.Deletado = true;
            subMenu.DeletadoData = DateTime.Now;
            _context.SubMenu.Update(subMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubMenuExists(int id)
        {
            return _context.SubMenu.Any(e => e.Id == id);
        }
    }
}
