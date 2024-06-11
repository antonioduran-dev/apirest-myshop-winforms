using Microsoft.AspNetCore.Mvc;
using MyShop.DTOs;
using MyShop.Services.Interfaces;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserDTO>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<UserDTO> list = await _userService.Get();

                return Ok(list);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await _userService.Get(id);


                return model != null ? Ok(model) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO model)
        {
            try
            {
                UserDTO response = await _userService.Create(model);

                return Created($"http://localhost:5053/api/usertype/{response.IdType}", response);
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
        public async Task<IActionResult> Put([FromBody] UserDTO model)
        {
            try
            {
                bool response = await _userService.Edit(model);

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
                bool response = await _userService.Delete(id);

                return response ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
