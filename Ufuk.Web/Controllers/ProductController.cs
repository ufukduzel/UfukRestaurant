using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        public async Task<IActionResult> ProductIndex() // 98th step. (Razor View - Empty)
        {
            // 95th step.
            //List<ProductDto> list = new List<ProductDto>(); // We can just use new() with new C#.
            // 96th step.
            List<ProductDto> list = new(); // A debugging point for API Call.
            var response = await _productService.GetAllProductsAsync<ResponseDto>();
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(list);
        }

        // 101st step.
        public async Task<IActionResult> ProductCreate() // 102nd step. (Razor View - Empty)
        {
            return View();
        }
        // 108th step.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductCreate(ProductDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProductAsync<ResponseDto>(model);
                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            return View(model);
        }
        // 109th step.
        public async Task<IActionResult> ProductEdit(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDto>(productId);
            if (response != null && response.IsSuccess)
            {
                ProductDto model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }
    }
}
