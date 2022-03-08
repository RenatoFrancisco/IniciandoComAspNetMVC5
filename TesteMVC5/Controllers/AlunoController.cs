using System;
using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno
            {
                Id = 1,
                Nome = "Renato",
                CPF = "12345678900",
                DataMatricula = DateTime.Now,
                Email = "renato@teste.com",
                Ativo = true
            };

            return RedirectToAction("Index", aluno);
        }

        public ActionResult Index(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);
            return View(aluno);
        }
    }
}