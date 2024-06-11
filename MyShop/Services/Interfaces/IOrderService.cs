using MyShop.DTOs;

namespace MyShop.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderDTO>> Get();
        Task<OrderDTO> Get(int id);
        Task<OrderDTO> Create(OrderDTO model);
        Task<bool> Edit(OrderDTO model);
        Task<bool> Delete(int id);
    }
}
