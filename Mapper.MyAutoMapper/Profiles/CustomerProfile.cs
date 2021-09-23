using AutoMapper;
using Mapper.Dto;
using Mapper.Entity;

namespace Mapper.MyAutoMapper.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}