using AutoMapper;
using MyShop.DTOs;
using MyShop.Models;
using MyShop.Repository.Interfaces;
using MyShop.Services.Interfaces;

namespace MyShop.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IGenericRepository<OrderDetail> _modelGeneric;
        private readonly IMapper _mapper;

        public OrderDetailService(IGenericRepository<OrderDetail> modelGeneric, IMapper mapper)
        {
            _modelGeneric = modelGeneric;
            _mapper = mapper;
        }

        public async Task<List<OrderDetailDTO>> Get()
        {
            try
            {
                return _mapper.Map<List<OrderDetailDTO>>(await _modelGeneric.Get()); // convert DB model to dto
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderDetailDTO> Get(int id)
        {
            try
            {
                var model = await _modelGeneric.Get(id);

                if (model != null)
                    return _mapper.Map<OrderDetailDTO>(model);
                else
                    return null!;
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
