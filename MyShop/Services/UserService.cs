using AutoMapper;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repository.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _modelGeneric;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> modelGeneric, IMapper mapper)
        {
            _modelGeneric = modelGeneric;
            _mapper = mapper;
        }

        public async Task<List<UserDTO>> Get()
        {
            try
            {
                return _mapper.Map<List<UserDTO>>(await _modelGeneric.Get()); // convert DB model to dto
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserDTO> Get(int id)
        {
            try
            {
                var model = await _modelGeneric.Get(id);

                if (model != null)
                    return _mapper.Map<UserDTO>(model);
                else
                    return null!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UserDTO> Create(UserDTO model)
        {
            try
            {
                var modelDB = _mapper.Map<User>(model); // convert to DB model
                var resModel = await _modelGeneric.Create(modelDB);

                if (resModel.IdType != 0)
                    return _mapper.Map<UserDTO>(resModel);
                else
                    throw new TaskCanceledException("No se pudo crear");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Edit(UserDTO model)
        {
            try
            {
                var modelDB = await _modelGeneric.Get(model.IdUser);

                if (modelDB != null)
                {
                    modelDB.IdType = model.IdType;
                    modelDB.Name = model.Name;
                    modelDB.Address = model.Address;
                    modelDB.Phone = model.Phone;
                    modelDB.Email = model.Email;

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
