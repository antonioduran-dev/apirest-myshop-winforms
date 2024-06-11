using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.DTOs;
using MyShop.Services.Interfaces;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OrderDTO>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<OrderDTO> list = await _orderService.Get();

                return Ok(list);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await _orderService.Get(id);


                return model != null ? Ok(model) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(OrderDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderDTO model)
        {
            try
            {
                OrderDTO response = await _orderService.Create(model);

                return Created($"http://localhost:5053/api/order/{response.IdOrder}", response);
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
        public async Task<IActionResult> Put([FromBody] OrderDTO model)
        {
            try
            {
                bool response = await _orderService.Edit(model);

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
                bool response = await _orderService.Delete(id);

                return response ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
