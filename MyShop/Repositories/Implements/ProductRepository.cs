using Microsoft.EntityFrameworkCore;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repositories.Interfaces;
using MyShop.Repository.DBContext;
using MyShop.Repository.Service;

namespace MyShop.Repositories.Implements
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ShopDbContext _dbContext;
        public ProductRepository(ShopDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task UpdateStock(int? productId, int quantity)
        {
            try
            {
                var product = await _dbContext.Products.FindAsync(productId);
                if (product != null)
                {
                    product.Stock -= quantity;
                    if (product.Stock < 0)
                    {
                        throw new InvalidOperationException("Stock insuficiente");
                    }
                    await _dbContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
