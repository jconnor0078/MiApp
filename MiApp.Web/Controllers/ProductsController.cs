using Abp.Web.Mvc.Authorization;
using MiApp.Authorization;
using MiApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MiApp.Web.Controllers
{

    
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        // GET: Products


        public async Task<ActionResult> Index()
        {
            var output = await _productAppService.GetProducts();
            return View(output);
        }
    }
}