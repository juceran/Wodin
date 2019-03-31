using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wodin.Comuns;
using Wodin.Context;
using Wodin.Models;
using Wodin.Models.Enums;
using System.Linq;
using System.Threading.Tasks;

namespace Wodin.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly WodinContext _context;

        public EmpresasController(WodinContext context)
        {
            _context = context;
        }

        // GET: Empresas
        public async Task<IActionResult> Index()
        {
            var Consulta = _context.Empresa.OrderBy(e => e.RazaoSocial).Where(e => e.Deletado == false);
            foreach (var item in Consulta)
            {
                item.CNPJ = FormatarString.FormateCPForCNPJ(item.CNPJ);
            }
            return View(await Consulta.ToListAsync());
        }

        // GET: Empresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            Empresa empresa = new Empresa
            {
                Ativo = true,
                DataCadastro = DateTime.Now
            };
            return View(empresa);
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Database,CNPJ,IE,RazaoSocial,Fantasia,DataAbertura,Email,Website,CEP,Logradouro,Numero,Complemento,Bairro,Cidade,Uf,Unidade,IBGE,GIA,Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                empresa.CNPJ = RemoverCaracteres.StringSemFormatacao(empresa.CNPJ);
                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empresa);
        }

        // GET: Empresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa.FindAsync(id);            
            if (empresa == null)
            {
                return NotFound();
            }
            empresa.CNPJ = FormatarString.FormateCPForCNPJ(empresa.CNPJ);
            empresa.UltimaAtualizacao = DateTime.Now;
            return View(empresa);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Database,CNPJ,IE,RazaoSocial,Fantasia,DataAbertura,Email,Website,CEP,Logradouro,Numero,Complemento,Bairro,Cidade,Uf,Unidade,IBGE,GIA,Id,Ativo,DataCadastro")] Empresa empresa)
        {
            if (id != empresa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Remover caracteres do CPForCNPJ
                    empresa.CNPJ = RemoverCaracteres.StringSemFormatacao(empresa.CNPJ);
                    if(empresa.Deletado != true)
                    {
                        empresa.Deletado = false;
                    }
                    _context.Update(empresa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaExists(empresa.Id))
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
            return View(empresa);
        }

        // GET: Empresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empresa = await _context.Empresa.FindAsync(id);
            empresa.Ativo = false;
            empresa.Deletado = true;
            empresa.DeletadoData = DateTime.Now;
            _context.Empresa.Update(empresa);
            //_context.Empresa.Remove(empresa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaExists(int id)
        {
            return _context.Empresa.Any(e => e.Id == id);
        }
    }
}
