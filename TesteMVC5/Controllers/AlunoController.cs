using System;
using System.Linq;
using System.Web.Mvc;
using TesteMVC5.Data;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AppDbContext _context = new AppDbContext();

        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        [HttpPost()]
        [ValidateAntiForgeryToken]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            aluno.DataMatricula = DateTime.Now;
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return View(aluno);
        }

        [HttpGet()]
        [Route("obter-alunos")]
        public ActionResult ObterAlunos()
        {
            var alunos = _context.Alunos.ToList();
            return View("NovoAluno", alunos.FirstOrDefault());
        }

        [HttpGet()]
        [Route("editar-aluno")]
        public ActionResult EditarAluno()
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Nome == "Renato");

            aluno.Nome = "João";
            var entry = _context.Entry(aluno);
            _context.Set<Aluno>().Attach(aluno);
            entry.State = System.Data.Entity.EntityState.Modified;

            _context.SaveChanges();

            var alunoNovo = _context.Alunos.Find(aluno.Id);
            return View("NovoAluno", alunoNovo);
        }

        [HttpGet()]
        [Route("excluir-aluno")]
        public ActionResult ExluirAluno()
        {
            var aluno = _context.Alunos.FirstOrDefault(a => a.Nome == "João");

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            var alunos = _context.Alunos.ToList();
            return View("NovoAluno", alunos.FirstOrDefault());
        }
    }
}