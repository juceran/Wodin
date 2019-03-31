using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Context;
using Wodin.Models;

namespace Wodin.Controllers
{
    public class FormaPagamentosController : Controller
    {
        private readonly WodinContext _context;

        public FormaPagamentosController(WodinContext context)
        {
            _context = context;
        }

        // GET: FormaPagamentos
        public async Task<IActionResult> Index()
        {
            var consulta = _context.FormaPagamento
                                                .Include(f => f.Empresa)
                                                .OrderBy(f => f.Descricao)
                                                .Where(f => f.Deletado == false)
                                                .Where(f => f.EmpresaId == Program.EmpresaId);
            return View(await consulta.ToListAsync());
        }

        // GET: FormaPagamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagamento = await _context.FormaPagamento
                .Include(f => f.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaPagamento == null)
            {
                return NotFound();
            }

            return View(formaPagamento);
        }

        // GET: FormaPagamentos/Create
        public IActionResult Create()
        {
            FormaPagamento formaPagamento = new FormaPagamento
            {
                Ativo = true,
                EmpresaId = Program.EmpresaId
            };
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia");
            return View(formaPagamento);
        }

        // POST: FormaPagamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,GeraFinanceiro,BaixaLancamento,CartaoCredito,CartaoDeCredito,CartaoCreditoVencimento,CartaoCreditoMelhorDia,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData,FormaPagamentoTipo")] FormaPagamento formaPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaPagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", formaPagamento.EmpresaId);
            return View(formaPagamento);
        }

        // GET: FormaPagamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagamento = await _context.FormaPagamento.FindAsync(id);
            if (formaPagamento == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", formaPagamento.EmpresaId);
            return View(formaPagamento);
        }

        // POST: FormaPagamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descricao,GeraFinanceiro,BaixaLancamento,CartaoCredito,CartaoDeCredito,CartaoCreditoVencimento,CartaoCreditoMelhorDia,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData,FormaPagamentoTipo")] FormaPagamento formaPagamento)
        {
            if (id != formaPagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaPagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaPagamentoExists(formaPagamento.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", formaPagamento.EmpresaId);
            return View(formaPagamento);
        }

        // GET: FormaPagamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPagamento = await _context.FormaPagamento
                .Include(f => f.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formaPagamento == null)
            {
                return NotFound();
            }

            return View(formaPagamento);
        }

        // POST: FormaPagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaPagamento = await _context.FormaPagamento.FindAsync(id);
            formaPagamento.Ativo = false;
            formaPagamento.Deletado = true;
            formaPagamento.DeletadoData = DateTime.Now;
            _context.FormaPagamento.Update(formaPagamento);
            //_context.FormaPagamento.Remove(formaPagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaPagamentoExists(int id)
        {
            return _context.FormaPagamento.Any(e => e.Id == id);
        }
    }
}
