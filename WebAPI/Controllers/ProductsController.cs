using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using Core.Utilities.Results;
using Domain.Concrete.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productservice;
        public ProductsController(IProductService productService)
        {
            _productservice = productService;
        }

        [HttpPost]
          public IActionResult Add(Product product)
         {
            var result = _productservice.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
         }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _productservice.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }
    }
}
