using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Comuns;
using Wodin.Context;
using Wodin.Models;

namespace Wodin.Controllers.Comum
{
    public class AdmEmpresasController : Controller
    {
        private readonly AdmContext _context;

        public AdmEmpresasController(AdmContext context)
        {
            _context = context;
        }

        // GET: ComumEmpresas
        public async Task<IActionResult> Index()
        {
            var Dados = _context.Empresa.OrderBy(e => e.RazaoSocial).Where(e => e.Deletado == false);
            foreach (var item in Dados)
            {
                item.CNPJ = FormatarString.FormateCPForCNPJ(item.CNPJ);
            }
            return View(await Dados.ToListAsync());
        }

        // GET: ComumEmpresas/Details/5
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

        // GET: ComumEmpresas/Create
        public IActionResult Create()
        {
            Empresa empresa = new Empresa
            {
                Ativo = true,
                DataCadastro = DateTime.Now
            };
            return View(empresa);
        }

        // POST: ComumEmpresas/Create
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

        // GET: ComumEmpresas/Edit/5
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

        // POST: ComumEmpresas/Edit/5
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
                    if (empresa.Deletado != true)
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

        // GET: ComumEmpresas/Delete/5
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

        // POST: ComumEmpresas/Delete/5
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