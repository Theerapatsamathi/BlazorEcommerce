using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorMCIC.Shared;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMCIC.Server.Services.CategoryService;
using BlazorMCIC.Server.Services.ProductService;

namespace BlazorMCIC.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController (IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProduct()
        {
            //อิงตาม interface
            return Ok(await _productService.GetAllProduct());

        }
        
        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            //อิงตาม interface
            return Ok(await _productService.GetProductsByCategory(categoryUrl));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }
    }
}
