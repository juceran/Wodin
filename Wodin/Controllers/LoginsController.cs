using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wodin.Comuns;
using Wodin.Context;
using Wodin.Models;
using Wodin.Services;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Wodin.Controllers
{
    public class LoginsController : Controller
    {
        private readonly AdmContext _context;
        private readonly WodinContext _contextAplicacao;
        private readonly LoginService _loginService;

        public LoginsController(AdmContext context, WodinContext contextAplicacao, LoginService loginService)
        {
            _context = context;
            _contextAplicacao = contextAplicacao;
            _loginService = loginService;
        }

        public IActionResult Login()
        {
            Login Login = new Login
            {
                CNPJ = "21.373.332/0001-91", Usuario = "JUCERAN", Senha = "1234"
            };
            return View(Login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Acessar(Login login)
        {
            if (ModelState.IsValid)
            {
                if (_loginService.ValidarAcesso(login))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["acesso"] = "Acesso não permitido!";
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
                //return RedirectToAction("Index", "Departamentos");
            }

        }
    }
}