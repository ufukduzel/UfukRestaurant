using Microsoft.AspNetCore.Mvc;
using Ufuk.Web.Models;
using Ufuk.Web.Services.IServices;

namespace Ufuk.Web.Controllers
{
    // 92nd step.
    public class ProductController : Controller
    {
        // 93rd step.
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // 94th step.
        public async Task<IActionResult> ProductIndex() // 95th step.
        {
            List<ProductDto> list = new List<ProductDto>();
            return View();
        }
    }
}
