using System.Web.Mvc;

namespace TesteMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("institucional/entre-em-contato")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ContentResult ContentResult()
        {
            return Content("Hello!");
        }

        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/Content/images/capa.png"));

            return File(foto, "image/png", "capa.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        public JsonResult JsonResult()
        {
            return Json("nome: 'Renato'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://desenvolvedor.io");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            //return RedirectToRoute(new
            //{
            //    controller = "Home",
            //    Action = "Index"
            //});

            return RedirectToAction("IndexTeste", "Teste");
        }
    }
}