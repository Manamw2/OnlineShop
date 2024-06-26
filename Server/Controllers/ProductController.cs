using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Product;
using Shared.Interfaces;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(await _productService.GetProductsAsync());
            }catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id){
             try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var product = await _productService.GetProductByIdAsync(id);
                if(product==null)
                    return NotFound();
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Policy = "PermissionAddProduct")]
        public async Task<IActionResult> AddProduct([FromBody] CreateProductDto productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                await _productService.AddProductAsync(productDto);
                return Ok("Product was successfully added");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
