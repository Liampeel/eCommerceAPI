using AutoMapper;
using eCommerce.Data.Context;
using eCommerce.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace eCommerce.Data.MapperProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(entity => entity.Customer, dto => dto.MapFrom(x => x.Customer))
                .ForMember(entity => entity.Products, dto => dto.MapFrom(x => x.Products)).ReverseMap();

            CreateMap<Order, OrderReturnDto>().ReverseMap();


            CreateMap<Customer, CustomerDto>()
                .ForMember(entity => entity.Address, dto => dto.MapFrom(x => x.Address))
                .ReverseMap();


            CreateMap<Address, AddressDto>().ReverseMap();


            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}