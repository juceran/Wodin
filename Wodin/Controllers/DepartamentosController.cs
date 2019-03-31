using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Context;
using Wodin.Services;
using Wodin.Models;

namespace Wodin.Controllers
{
    //[Authorize(Policy = "UsuarioLogado")]
    public class DepartamentosController : Controller
    {
        private readonly WodinContext _context;
        private readonly DepartamentoService _departamentoService;

        public DepartamentosController(WodinContext context, DepartamentoService departamentoService)
        {
            _context = context;
            _departamentoService = departamentoService;
        }

        // GET: Departamentos
        public async Task<IActionResult> Index()
        {
            var salesWebMvcContext = _context.Departamento
                                        .Include(e => e.Empresa)
                                        .OrderBy(d => d.Nome)
                                        .Where(d => d.Deletado == false)
                                        .Where(d => d.EmpresaId == Program.EmpresaId);
            return View(await salesWebMvcContext.ToListAsync());
        }

        // GET: Departamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamento
                .Include(e => e.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // GET: Departamentos/Create
        public IActionResult Create()
        {
            Departamento departamento = new Departamento { DataCadastro = DateTime.Now, Ativo = true };
            ViewData["EmpresaId"] = new SelectList(_context.Empresa.OrderBy(x => x.Fantasia), "Id", "Fantasia");
            return View(departamento);
        }

        // POST: Departamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,EmpresaId,Id,Ativo,DataCadastro")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                //padrão dos campos
                departamento.Nome = departamento.Nome.ToUpper();

                //Verifica duplicidade no nome do departamento
                if (_departamentoService.DepartamentoExiste(departamento))
                {
                    ViewData["Message"] = "Nome do Departamento em duplicidade!";
                    ViewData["EmpresaId"] = new SelectList(_context.Empresa.OrderBy(x => x.Fantasia), "Id", "Fantasia");
                    return View(departamento);
                }

                _context.Add(departamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", departamento.EmpresaId);
            return View(departamento);
        }

        // GET: Departamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamento.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", departamento.EmpresaId);
            return View(departamento);
        }

        // POST: Departamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao")] Departamento departamento)
        {
            if (id != departamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    departamento.Deletado = false;
                    departamento.UltimaAtualizacao = DateTime.Now;
                    _context.Update(departamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartamentoExists(departamento.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa.OrderBy(x => x.Fantasia), "Id", "Fantasia", departamento.EmpresaId);
            return View(departamento);
        }

        // GET: Departamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamento
                .Include(d => d.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // POST: Departamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departamento = await _context.Departamento.FindAsync(id);
            departamento.Ativo = false;
            departamento.Deletado = true;
            departamento.DeletadoData = DateTime.Now;
            _context.Departamento.Update(departamento);
            //_context.Departamento.Remove(departamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartamentoExists(int id)
        {
            return _context.Departamento.Any(e => e.Id == id);
        }
    }
}
