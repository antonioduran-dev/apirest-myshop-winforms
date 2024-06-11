using MyShop.DTOs;

namespace MyShop.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDTO>> Get();
        Task<ProductDTO> Get(int id);
        Task<ProductDTO> Create(ProductDTO model);
        Task<bool> Edit(ProductDTO model);
        Task<bool> Delete(int id);
    }
}
