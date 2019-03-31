using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Context;
using Wodin.Models;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace Wodin.Controllers
{
    public class PrazoPagamentosController : Controller
    {
        private readonly WodinContext _context;

        public PrazoPagamentosController(WodinContext context)
        {
            _context = context;
        }

        // GET: PrazoPagamentos
        public async Task<IActionResult> Index()
        {
            var salesWebMvcContext = _context.PrazoPagamento.Include(p => p.Empresa).OrderBy(O => O.Descricao);
            return View(await salesWebMvcContext.ToListAsync());
        }

        // GET: PrazoPagamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prazoPagamento = await _context.PrazoPagamento
                .Include(p => p.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prazoPagamento == null)
            {
                return NotFound();
            }

            return View(prazoPagamento);
        }

        // GET: PrazoPagamentos/Create
        public IActionResult Create()
        {
            PrazoPagamento prazoPagamento = new PrazoPagamento
            {
                Ativo = true,
                EmpresaId = Program.EmpresaId
            };
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia");
            return View(prazoPagamento);
        }

        // POST: PrazoPagamentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Parcelas,PrimeiraParcela,DiasParcela,Limite,PrazoMedio,BaixaLancamento,PrazoPagamentoTipo,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] PrazoPagamento prazoPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prazoPagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", prazoPagamento.EmpresaId);
            return View(prazoPagamento);
        }

        // GET: PrazoPagamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prazoPagamento = await _context.PrazoPagamento.FindAsync(id);
            if (prazoPagamento == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", prazoPagamento.EmpresaId);
            return View(prazoPagamento);
        }

        // POST: PrazoPagamentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descricao,Parcelas,PrimeiraParcela,DiasParcela,Limite,PrazoMedio,BaixaLancamento,PrazoPagamentoTipo,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] PrazoPagamento prazoPagamento)
        {
            if (id != prazoPagamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prazoPagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrazoPagamentoExists(prazoPagamento.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia", prazoPagamento.EmpresaId);
            return View(prazoPagamento);
        }

        // GET: PrazoPagamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prazoPagamento = await _context.PrazoPagamento
                .Include(p => p.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prazoPagamento == null)
            {
                return NotFound();
            }

            return View(prazoPagamento);
        }

        // POST: PrazoPagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prazoPagamento = await _context.PrazoPagamento.FindAsync(id);
            prazoPagamento.Ativo = false;
            prazoPagamento.Deletado = true;
            prazoPagamento.DeletadoData = DateTime.Now;
            _context.PrazoPagamento.Update(prazoPagamento);
            //_context.PrazoPagamento.Remove(prazoPagamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrazoPagamentoExists(int id)
        {
            return _context.PrazoPagamento.Any(e => e.Id == id);
        }
    }
}
