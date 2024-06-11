using AutoMapper;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repository.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Services
{
    public class UserTypeService : IUserTypeService
    {
        private readonly IGenericRepository<UserType> _modelGeneric;
        private readonly IMapper _mapper;

        public UserTypeService(IGenericRepository<UserType> modelGeneric, IMapper mapper)
        {
            _modelGeneric = modelGeneric;
            _mapper = mapper;
        }

        public async Task<List<UserTypeDTO>> Get()
        {
            try
            {
                return _mapper.Map<List<UserTypeDTO>>(await _modelGeneric.Get()); // convert DB model to dto
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserTypeDTO> Get(int id)
        {
            try
            {
                var model = await _modelGeneric.Get(id);

                if (model != null)
                    return _mapper.Map<UserTypeDTO>(model);
                else
                    return null!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserTypeDTO> Create(UserTypeDTO model)
        {
            try
            {
                var modelDB = _mapper.Map<UserType>(model); // convert to DB model
                var resModel = await _modelGeneric.Create(modelDB);

                if (resModel.IdType != 0)
                    return _mapper.Map<UserTypeDTO>(resModel);
                else
                    throw new TaskCanceledException("No se pudo crear");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Edit(UserTypeDTO model)
        {
            try
            {
                var modelDB = await _modelGeneric.Get(model.IdType);

                if (modelDB != null)
                {
                    modelDB.Name = model.Name;

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
