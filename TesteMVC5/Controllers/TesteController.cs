using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    [RoutePrefix("testes")]
    public class TesteController : Controller
    {
        [Route]
        public ActionResult IndexTeste()
        {
            return View();
        }

        [Route("um-outro-teste")]
        public ActionResult IndexTeste2()
        {
            return View("IndexTeste");
        }
    }
}