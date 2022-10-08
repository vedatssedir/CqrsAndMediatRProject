using AutoMapper;
using CqrsMediatR.Domain;
using WebApi.Models;

namespace WebApi.Profiles
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, GetAllCustomerResponseDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerRequestDto>().ReverseMap();
        }
    }
}
