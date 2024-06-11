using Microsoft.AspNetCore.Mvc;
using MyShop.DTOs;
using MyShop.Services.Interfaces;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        private readonly IUserTypeService _userTypeService;
        public UserTypeController(IUserTypeService userTypeService)
        {
            _userTypeService = userTypeService;
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UserTypeDTO>))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<UserTypeDTO> list = await _userTypeService.Get();

                return Ok(list);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserTypeDTO))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await _userTypeService.Get(id);


                return model != null ? Ok(model) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // indicamos el status que devuelve este método, y el tipo de dato devuelto.
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserTypeDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserTypeDTO model)
        {
            try
            {
                UserTypeDTO response = await _userTypeService.Create(model);

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
        public async Task<IActionResult> Put([FromBody] UserTypeDTO model)
        {
            try
            {
                bool response = await _userTypeService.Edit(model);

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
                bool response = await _userTypeService.Delete(id);

                return response ? Ok(response) : NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
