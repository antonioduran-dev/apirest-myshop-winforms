using AutoMapper;
using MyShop.DTOs;
using MyShop.Models;

namespace MyShop.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDTO>(); // convert to DTO
            CreateMap<CategoryDTO, Category>(); // convert to DB model

            CreateMap<Product, ProductDTO>(); // convert to DTO
            CreateMap<ProductDTO, Product>(); // convert to DB model

            CreateMap<UserType, UserTypeDTO>(); // convert to DTO
            CreateMap<UserTypeDTO, UserType>(); // convert to DB model

            CreateMap<Order, OrderDTO>(); // convert to DTO
            CreateMap<OrderDTO, Order>(); // convert to DB model

            CreateMap<OrderDetail, OrderDetailDTO>(); // convert to DTO
            CreateMap<OrderDetailDTO, OrderDetail>(); // convert to DB model

            CreateMap<User, UserDTO >(); // convert to DTO
            CreateMap<UserDTO, User>(); // convert to DB model
        }
    }
}
