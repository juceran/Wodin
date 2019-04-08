using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wodin.Comuns;
using Wodin.Context;
using Wodin.Models;
using Wodin.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Wodin.Controllers
{
    public class PessoasController : Controller
    {
        private readonly WodinContext _context;
        private readonly PessoaService _pessoaService;

        public PessoasController(WodinContext context, PessoaService pessoaService)
        {
            _context = context;
            _pessoaService = pessoaService;
        }

        // GET: Pessoas
        public async Task<IActionResult> Index()
        {
            IQueryable<Pessoa> Consulta = _context.Pessoa
                                        .Include(p => p.PessoaCliente)
                                        .Include(p => p.PessoaFisica)
                                        .Include(p => p.PessoaFornecedor)
                                        .Include(p => p.PessoaJuridica)
                                        .Include(p => p.PessoaUsuario)
                                        .Include(P => P.UsuarioPermissaoAcesso)
                                        .OrderBy(p => p.Descricao)
                                        .Where(p => p.Deletado == false)
                                        .Where(p => p.EmpresaId == Program.EmpresaId);
            return View(await Consulta.ToListAsync());
        }

        // GET: Pessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa pessoa = await _context.Pessoa
                .Include(p => p.PessoaCliente)
                .Include(p => p.PessoaFisica)
                .Include(p => p.PessoaFornecedor)
                .Include(p => p.PessoaJuridica)
                .Include(p => p.PessoaUsuario)
                .Include(p => p.PessoaEmail)
                .Include(p => p.PessoaEndereco)
                .Include(p => p.PessoaTelefone)
                .Include(p => p.UsuarioPermissaoAcesso)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // GET: Pessoas/Create
        public IActionResult Create()
        {
            //somente enquanto não implementa a AUTENTICAÇÃO
            if (Program.EmpresaId < 1)
            {
                Program.EmpresaId = 1;
            }

            Pessoa pessoa = new Pessoa
            {
                EmpresaId = Program.EmpresaId,
                DataCadastro = DateTime.Now,
                UltimaAtualizacao = DateTime.Now,
                Ativo = true,
                PessoaCliente = new PessoaCliente
                {
                    LimiteCredito = 1355
                },
                PessoaFornecedor = new PessoaFornecedor(),
                PessoaFisica = new PessoaFisica(),
                PessoaJuridica = new PessoaJuridica(),
                PessoaUsuario = new PessoaUsuario(),
                UsuarioPermissaoAcesso = new Models.UsuarioPermissaoAcesso()
            };
            FormaPagamento formaPagamento = new FormaPagamento();
            ViewData["FormaRecebimentoId"] = new SelectList(_context.FormaPagamento
                                                            .OrderBy(x => x.Descricao)
                                                            .Where(f => f.Deletado == false)
                                                            .Where(f => f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Ambos || f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Receber)
                                                            .Where(f => f.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            PrazoPagamento prazoPagamento = new PrazoPagamento();
            ViewData["PrazoRecebimentoId"] = new SelectList(_context.PrazoPagamento
                                                            .OrderBy(p => p.Descricao)
                                                            .Where(p => p.Deletado == false)
                                                            .Where(p => p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Ambos || p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Receber)
                                                            .Where(p => p.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            ViewData["FormaPagamentoId"] = new SelectList(_context.FormaPagamento
                                                            .OrderBy(x => x.Descricao)
                                                            .Where(f => f.Deletado == false)
                                                            .Where(f => f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Ambos || f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Pagar)
                                                            .Where(f => f.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            ViewData["PrazoPagamentoId"] = new SelectList(_context.PrazoPagamento
                                                            .OrderBy(p => p.Descricao)
                                                            .Where(p => p.Deletado == false)
                                                            .Where(p => p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Ambos || p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Pagar)
                                                            .Where(p => p.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            return View(pessoa);
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpresaId,Descricao,DataCadastro,Ativo,UltimaAtualizacao,Deletado,DeletadoData," +
            "PessoaCliente,PessoaFornecedor,PessoaFisica,PessoaJuridica,PessoaUsuario,UsuarioPermissaoAcesso")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                if (_pessoaService.ValidarPessoaUsuario(pessoa))
                {
                    ViewData["Message"] = "Nome de usuário em duplicidade!";
                    return View(pessoa);
                }

                //tratar caracteres
                pessoa.PessoaFisica.CPF = RemoverCaracteres.StringSemFormatacao(pessoa.PessoaFisica.CPF);
                pessoa.PessoaJuridica.CNPJ = RemoverCaracteres.StringSemFormatacao(pessoa.PessoaJuridica.CNPJ);
                pessoa.PessoaUsuario.PessoaUsuarioSenha.Senha = CodificarString.RetornarMD5(pessoa.PessoaUsuario.PessoaUsuarioSenha.Senha);

                if(pessoa.PessoaUsuario.User == true)
                {
                    pessoa.UsuarioPermissaoAcesso.EmpresaId = Program.EmpresaId; 
                }

                _context.Add(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pessoa pessoa = await _context.Pessoa
                          .Include(p => p.PessoaCliente)
                          .Include(p => p.PessoaFisica)
                          .Include(p => p.PessoaFornecedor)
                          .Include(p => p.PessoaJuridica)
                          .Include(p => p.PessoaUsuario)
                          .Include(p => p.UsuarioPermissaoAcesso)
                          .FirstOrDefaultAsync(m => m.Id == id);
            //var pessoa = await _context.Pessoa.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }
            FormaPagamento formaPagamento = new FormaPagamento();
            ViewData["FormaRecebimentoId"] = new SelectList(_context.FormaPagamento
                                                            .OrderBy(x => x.Descricao)
                                                            .Where(f => f.Deletado == false)
                                                            .Where(f => f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Ambos || f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Receber)
                                                            .Where(f => f.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            PrazoPagamento prazoPagamento = new PrazoPagamento();
            ViewData["PrazoRecebimentoId"] = new SelectList(_context.PrazoPagamento
                                                            .OrderBy(p => p.Descricao)
                                                            .Where(p => p.Deletado == false)
                                                            .Where(p => p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Ambos || p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Receber)
                                                            .Where(p => p.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            ViewData["FormaPagamentoId"] = new SelectList(_context.FormaPagamento
                                                            .OrderBy(x => x.Descricao)
                                                            .Where(f => f.Deletado == false)
                                                            .Where(f => f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Ambos || f.FormaPagamentoTipo == Models.Enums.FormaPagamentoTipo.Pagar)
                                                            .Where(f => f.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            ViewData["PrazoPagamentoId"] = new SelectList(_context.PrazoPagamento
                                                            .OrderBy(p => p.Descricao)
                                                            .Where(p => p.Deletado == false)
                                                            .Where(p => p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Ambos || p.PrazoPagamentoTipo == Models.Enums.PrazoPagamentoTipo.Pagar)
                                                            .Where(p => p.EmpresaId == Program.EmpresaId), "Id", "Descricao");
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ativo,DataCadastro,UltimaAtualizacao,Deletado,DeletadoData,Descricao,EmpresaId," +
                                                            "PessoaCliente," +
                                                            "PessoaFornecedor," +
                                                            "PessoaFisica," +
                                                            "PessoaJuridica," +
                                                            "PessoaUsuario," +
                                                            "UsuarioPermissaoAcesso")] Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //tratar caracteres
                    pessoa.PessoaFisica.CPF = RemoverCaracteres.StringSemFormatacao(pessoa.PessoaFisica.CPF);
                    pessoa.PessoaJuridica.CNPJ = RemoverCaracteres.StringSemFormatacao(pessoa.PessoaJuridica.CNPJ);
                    pessoa.PessoaUsuario.PessoaUsuarioSenha.Senha = CodificarString.RetornarMD5(pessoa.PessoaUsuario.PessoaUsuarioSenha.Senha);

                    _context.Update(pessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaExists(pessoa.Id))
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
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pessoa pessoa = await _context.Pessoa
                .Include(p => p.PessoaCliente)
                .Include(p => p.PessoaFisica)
                .Include(p => p.PessoaFornecedor)
                .Include(p => p.PessoaJuridica)
                .Include(p => p.PessoaUsuario)
                .Include(p => p.UsuarioPermissaoAcesso)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Pessoa pessoa = await _context.Pessoa.FindAsync(id);

            pessoa.Ativo = false;
            pessoa.Deletado = true;
            pessoa.DeletadoData = DateTime.Now;
            _context.Pessoa.Update(pessoa);
            //_context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaExists(int id)
        {
            return _context.Pessoa.Any(e => e.Id == id);
        }
    }
}
