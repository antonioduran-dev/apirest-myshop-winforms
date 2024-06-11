using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.DTOs;
using MyShop.Services.Interfaces;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;
        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<OrderDetailDTO>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<OrderDetailDTO> list = await _orderDetailService.Get();

                return Ok(list);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderDetailDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await _orderDetailService.Get(id);


                return model != null ? Ok(model) : NotFound();
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
                bool response = await _orderDetailService.Delete(id);

                return response ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
