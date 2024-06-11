using MyShop.Models;
using MyShop.Repository.Interfaces;

namespace MyShop.Repositories.Interfaces
{
    // creamos la interfaz para crear la lógica de negocios de los productos,
    // y heredamos del repositorio genérico creado.
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task UpdateStock(int? productId, int quantity);
    }
}
