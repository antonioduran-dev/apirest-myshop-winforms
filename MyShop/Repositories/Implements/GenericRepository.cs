using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyShop.DTOs;
using MyShop.Repository.DBContext;
using MyShop.Repository.Interfaces;

namespace MyShop.Repository.Service
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly ShopDbContext _dbContext;
        public GenericRepository(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TModel>> Get()
        {
            try
            {
                return await _dbContext.Set<TModel>().ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TModel> Get(int? id)
        {
            try
            {
                return await _dbContext.Set<TModel>().FindAsync(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TModel> Create(TModel model)
        {
            try
            {
                await _dbContext.Set<TModel>().AddAsync(model);
                await _dbContext.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Edit(TModel model)
        {
            try
            {
                _dbContext.Set<TModel>().Update(model);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Delete(TModel model)
        {
            try
            {
                _dbContext.Set<TModel>().Remove(model);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
