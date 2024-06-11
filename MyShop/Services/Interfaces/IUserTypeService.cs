using MyShop.DTOs;

namespace MyShop.Services.Interfaces
{
    public interface IUserTypeService
    {
        Task<List<UserTypeDTO>> Get();
        Task<UserTypeDTO> Get(int id);
        Task<UserTypeDTO> Create(UserTypeDTO model);
        Task<bool> Edit(UserTypeDTO model);
        Task<bool> Delete(int id);
    }
}
