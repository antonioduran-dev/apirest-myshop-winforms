using MyShop.DTOs;
using MyShop.Models;

namespace MyShop.Services.Interfaces
{
    public interface IOrderDetailService
    {
        Task<List<OrderDetailDTO>> Get();
        Task<OrderDetailDTO> Get(int id);
        Task<bool> Delete(int id);
    }
}
