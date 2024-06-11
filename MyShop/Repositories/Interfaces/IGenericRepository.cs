using MyShop.DTOs;

namespace MyShop.Repository.Interfaces
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        Task<List<TModel>> Get();
        Task<TModel> Get(int? id);
        Task<TModel> Create(TModel model);
        Task<bool> Edit(TModel model);
        Task<bool> Delete(TModel model);
    }
}
