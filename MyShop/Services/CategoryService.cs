using AutoMapper;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repository.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _modelGeneric;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> modelGeneric, IMapper mapper)
        {
            _modelGeneric = modelGeneric;
            _mapper = mapper;
        }

        public async Task<List<CategoryDTO>> Get()
        {
            try
            {
                return _mapper.Map<List<CategoryDTO>>(await _modelGeneric.Get()); // convert DB model to dto
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CategoryDTO> Get(int id)
        {
            try
            {
                var model = await _modelGeneric.Get(id);

                if (model != null)
                    return _mapper.Map<CategoryDTO>(model);
                else
                    return null!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<CategoryDTO> Create(CategoryDTO model)
        {
            try
            {
                var modelDB = _mapper.Map<Category>(model); // convert to DB model
                var resModel = await _modelGeneric.Create(modelDB);

                if (resModel.IdCategory != 0)
                    return _mapper.Map<CategoryDTO>(resModel);
                else
                    throw new TaskCanceledException("No se pudo crear");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Edit(CategoryDTO model)
        {
            try
            {
                var modelDB = await _modelGeneric.Get(model.IdCategory);

                if (modelDB != null)
                {
                    modelDB.CategoryName = model.CategoryName;

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
