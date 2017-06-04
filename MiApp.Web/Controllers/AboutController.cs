using System.Web.Mvc;

namespace MiApp.Web.Controllers
{
    public class AboutController : MiAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}