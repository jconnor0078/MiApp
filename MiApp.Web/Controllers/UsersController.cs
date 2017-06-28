using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MiApp.Authorization;
using MiApp.Users;
using System.Web.Services;
using System.Linq;

namespace MiApp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : MiAppControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }

        [HttpPost]
        public JsonResult GetUserList()
        {
            var output = _userAppService.GetLisU();

            return Json(new { Result = "OK", Records = output } );
        }
    }
}