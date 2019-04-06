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
    public class UsuarioPermissaoAcessosController : Controller
    {
        private readonly WodinContext _context;

        public UsuarioPermissaoAcessosController(WodinContext context)
        {
            _context = context;
        }

        // GET: UsuarioPermissaoAcessos
        public async Task<IActionResult> Index(int filtroUsuario, string filtro)
        {
            ViewData["filtro"] = filtro;
            ViewData["filtroMenu"] = filtroUsuario;

            var wodinContext = _context.UsuarioPermissaoAcesso.Include(u => u.Empresa).Include(p => p.Pessoa);
            return View(await wodinContext.ToListAsync());
        }

        // GET: UsuarioPermissaoAcessos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioPermissaoAcesso = await _context.UsuarioPermissaoAcesso
                .Include(u => u.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioPermissaoAcesso == null)
            {
                return NotFound();
            }

            return View(usuarioPermissaoAcesso);
        }

        // GET: UsuarioPermissaoAcessos/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Fantasia");
            ViewData["PessoaId"] = new SelectList(_context.PessoaUsuario, "PessoaId", "Usuario");
            return View();
        }

        // POST: UsuarioPermissaoAcessos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Visualizar,Incluir,Editar,Imprimir,Baixar,Cancelar,CancelarBaixa,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] UsuarioPermissaoAcesso usuarioPermissaoAcesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioPermissaoAcesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Uf", usuarioPermissaoAcesso.EmpresaId);
            return View(usuarioPermissaoAcesso);
        }

        // GET: UsuarioPermissaoAcessos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioPermissaoAcesso = await _context.UsuarioPermissaoAcesso.FindAsync(id);
            if (usuarioPermissaoAcesso == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Uf", usuarioPermissaoAcesso.EmpresaId);
            return View(usuarioPermissaoAcesso);
        }

        // POST: UsuarioPermissaoAcessos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Visualizar,Incluir,Editar,Imprimir,Baixar,Cancelar,CancelarBaixa,EmpresaId,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] UsuarioPermissaoAcesso usuarioPermissaoAcesso)
        {
            if (id != usuarioPermissaoAcesso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioPermissaoAcesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioPermissaoAcessoExists(usuarioPermissaoAcesso.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresa, "Id", "Uf", usuarioPermissaoAcesso.EmpresaId);
            return View(usuarioPermissaoAcesso);
        }

        // GET: UsuarioPermissaoAcessos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioPermissaoAcesso = await _context.UsuarioPermissaoAcesso
                .Include(u => u.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioPermissaoAcesso == null)
            {
                return NotFound();
            }

            return View(usuarioPermissaoAcesso);
        }

        // POST: UsuarioPermissaoAcessos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioPermissaoAcesso = await _context.UsuarioPermissaoAcesso.FindAsync(id);
            _context.UsuarioPermissaoAcesso.Remove(usuarioPermissaoAcesso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioPermissaoAcessoExists(int id)
        {
            return _context.UsuarioPermissaoAcesso.Any(e => e.Id == id);
        }
    }
}
