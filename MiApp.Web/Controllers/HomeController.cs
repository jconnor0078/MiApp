using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MiApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MiAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}