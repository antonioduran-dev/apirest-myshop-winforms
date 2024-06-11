using MyShop.DTOs;

namespace MyShop.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> Get();
        Task<CategoryDTO> Get(int id);
        Task<CategoryDTO> Create(CategoryDTO model);
        Task<bool> Edit(CategoryDTO model);
        Task<bool> Delete(int id);
    }
}
