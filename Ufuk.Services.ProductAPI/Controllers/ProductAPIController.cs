using Microsoft.AspNetCore.Mvc;
using Ufuk.Services.ProductAPI.Models.Dto;
using Ufuk.Services.ProductAPI.Models.Dtos;
using Ufuk.Services.ProductAPI.Repository;

namespace Ufuk.Services.ProductAPI.Controllers
{
    //26th step.
    [Route("api/products")]
    public class ProductAPIController : ControllerBase
    {
        //27th step.
        protected ResponseDto _response;
        private IProductRepository _productRepository;
        public ProductAPIController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            this._response = new ResponseDto();
        }

        //28th step.
        [HttpGet]
        public async Task<object> Get()
        {
            //30th step.
            try
            {
                IEnumerable<ProductDto> productDtos = await _productRepository.GetProducts();
                _response.Result = productDtos;
            }
            //29th step.
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage
                    = new List<string>() { ex.ToString() };
            }
            //31th step.
            return _response;
        }
    }
}
