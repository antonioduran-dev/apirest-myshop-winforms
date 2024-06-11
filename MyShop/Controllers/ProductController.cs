using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.DTOs;
using MyShop.Repositories.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Controllers
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

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ProductDTO>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<ProductDTO> list = await _productService.Get();

                return Ok(list);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await _productService.Get(id);


                return model != null ? Ok(model) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ProductDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductDTO model)
        {
            try
            {
                ProductDTO response = await _productService.Create(model);

                return Created($"http://localhost:5053/api/product/{response.IdProduct}", response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProductDTO model)
        {
            try
            {
                bool response = await _productService.Edit(model);

                return response ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool response = await _productService.Delete(id);

                return response ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
