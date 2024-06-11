using AutoMapper;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repository.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _modelGeneric;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> modelGeneric, IMapper mapper)
        {
            _modelGeneric = modelGeneric;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> Get()
        {
            try
            {
                return _mapper.Map<List<ProductDTO>>(await _modelGeneric.Get()); // convert DB model to dto
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductDTO> Get(int id)
        {
            try
            {
                var model = await _modelGeneric.Get(id);

                if (model != null)
                    return _mapper.Map<ProductDTO>(model);
                else
                    return null!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ProductDTO> Create(ProductDTO model)
        {
            try
            {
                var modelDB = _mapper.Map<Product>(model); // convert to DB model
                var resModel = await _modelGeneric.Create(modelDB);

                if (resModel.IdCategory != 0)
                    return _mapper.Map<ProductDTO>(resModel);
                else
                    throw new TaskCanceledException("No se pudo crear");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Edit(ProductDTO model)
        {
            try
            {
                var modelDB = await _modelGeneric.Get(model.IdProduct);

                if (modelDB != null)
                {
                    modelDB.IdCategory = model.IdCategory;
                    modelDB.Name = model.Name;
                    modelDB.Description = model.Description;
                    modelDB.Price = model.Price;
                    modelDB.Stock = model.Stock;

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
