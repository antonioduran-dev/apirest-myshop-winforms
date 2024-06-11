using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repositories.Interfaces;
using MyShop.Repository.DBContext;
using MyShop.Repository.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> _modelGeneric;
        private readonly IGenericRepository<OrderDetail> _detailModelGeneric;
        private readonly IProductRepository _productRepository;
        private readonly ShopDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrderService(IGenericRepository<Order> modelGeneric,
            ShopDbContext dbContext,
            IProductRepository productRepository,
            IGenericRepository<OrderDetail> detailModelGeneric,
            IMapper mapper)
        {
            _modelGeneric = modelGeneric;
            _dbContext = dbContext;
            _detailModelGeneric = detailModelGeneric;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderDTO>> Get()
        {
            try
            {
                return _mapper.Map<List<OrderDTO>>(await _modelGeneric.Get()); // convert DB model to dto
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderDTO> Get(int id)
        {
            try
            {
                var model = await _modelGeneric.Get(id);

                if (model != null)
                    return _mapper.Map<OrderDTO>(model);
                else
                    return null!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderDTO> Create(OrderDTO model)
        {
            // use transaction
            using(var trans = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var modelDB = _mapper.Map<Order>(model); // convert to DB model
                    var resModel = await _modelGeneric.Create(modelDB);
                    decimal total = 0;

                    if (resModel.IdOrder != 0)
                    {
                        foreach (var detail in resModel.OrderDetails)
                        {
                            detail.IdOrder = resModel.IdOrder;
                            // obtain product to get price and stock
                            var product = await _productRepository.Get(detail.IdProduct);

                            // verify stock
                            if (product != null && product.Stock > detail.Quantity)
                            {
                                // calculate the subtotal
                                detail.UnitPrice = product.Price;
                                detail.Subtotal = detail.Quantity * detail.UnitPrice;
                                total += detail.Subtotal;

                                // update stock product
                                await _productRepository.UpdateStock(detail.IdProduct, detail.Quantity);

                                // add detail to DB
                                await _detailModelGeneric.Edit(detail);
                            }

                        }

                        // set total to order
                        resModel.Total = total;

                        // update the order data
                        await _modelGeneric.Edit(resModel);

                        // confirm transaction
                        await trans.CommitAsync();

                        return _mapper.Map<OrderDTO>(resModel);
                    }
                    else
                        throw new TaskCanceledException("No se pudo crear");
                }
                catch (Exception ex)
                {
                    // revert the transaction
                    await trans.RollbackAsync();
                    throw new Exception(ex.Message);
                }
            }
            
            
        }

        public async Task<bool> Edit(OrderDTO model)
        {
            try
            {
                var modelDB = await _modelGeneric.Get(model.IdOrder);

                if (modelDB != null)
                {
                    modelDB.IdUser = model.IdUser;
                    modelDB.Total = model.Total;

                    var response = await _modelGeneric.Edit(modelDB);

                    return response;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var modelDB = await _modelGeneric.Get(id);

                if (modelDB != null)
                {
                    var response = await _modelGeneric.Delete(modelDB);

                    return response;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
