using System.Web.Mvc;
using TesteMVC5.Models;

namespace TesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }
    }
}