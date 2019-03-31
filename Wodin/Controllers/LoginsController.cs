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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Acessar(Login login)
        {
            if (ModelState.IsValid)
            {
                if (_loginService.ValidarAcesso(login))
                {
                    return RedirectToAction("Index", "Pessoas");
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