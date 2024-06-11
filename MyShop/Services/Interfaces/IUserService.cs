using MyShop.DTOs;

namespace MyShop.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> Get();
        Task<UserDTO> Get(int id);
        Task<UserDTO> Create(UserDTO model);
        Task<bool> Edit(UserDTO model);
        Task<bool> Delete(int id);
    }
}
