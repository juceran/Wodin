using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Context;
using Wodin.Services;
using Wodin.Models;

namespace Wodin.Controllers
{
    public class MenuUlsController : Controller
    {
        private readonly AdmContext _context;
        private readonly MenuService _menuService;

        public MenuUlsController(AdmContext context, MenuService menuService)
        {
            _context = context;
            _menuService = menuService;
        }



        // GET: MenuUls
        public async Task<IActionResult> Index()
        {
            return View(await _context.MenuUl.OrderBy(x => x.Menu).ToListAsync());
        }

        // GET: MenuUls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuUl = await _context.MenuUl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuUl == null)
            {
                return NotFound();
            }

            return View(menuUl);
        }

        // GET: MenuUls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MenuUls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Menu,Url,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] MenuUl menuUl)
        {
            if (ModelState.IsValid)
            {
                //Verifica duplicidade
                var menuExiste = _menuService.MenuExiste(menuUl);
                if (menuExiste)
                {
                    ViewData["Message"] = "Menu em duplicidade!";                   
                    return View(menuUl);
                }

                _context.Add(menuUl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(menuUl);
        }

        // GET: MenuUls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuUl = await _context.MenuUl.FindAsync(id);
            if (menuUl == null)
            {
                return NotFound();
            }
            return View(menuUl);
        }

        // POST: MenuUls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Menu,Url,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] MenuUl menuUl)
        {
            if (id != menuUl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menuUl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuUlExists(menuUl.Id))
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
            return View(menuUl);
        }

        // GET: MenuUls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menuUl = await _context.MenuUl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menuUl == null)
            {
                return NotFound();
            }

            return View(menuUl);
        }

        // POST: MenuUls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var menuUl = await _context.MenuUl.FindAsync(id);
            menuUl.Ativo = false;
            menuUl.Deletado = true;
            menuUl.DeletadoData = DateTime.Now;
            _context.MenuUl.Update(menuUl);
            //_context.MenuUl.Remove(menuUl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuUlExists(int id)
        {
            return _context.MenuUl.Any(e => e.Id == id);
        }
    }
}
