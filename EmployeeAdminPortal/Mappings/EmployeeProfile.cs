using AutoMapper;
using EmployeeAdminPortal.Models.Dtos.Requests;
using EmployeeAdminPortal.Models.Dtos.Responses;
using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<CreateEmployeeDto, Employee>()
                .ForMember(
                    dest => dest.Email,
                    opts => opts.MapFrom(src => src.EmailAddress))
                .ForMember(
                    dest => dest.Phone,
                    opts => opts.MapFrom(src => src.PhoneNumber));

            CreateMap<UpdateEmplyeeDto, Employee>()
                .ForMember(
                    dest => dest.Email,
                    opts => opts.MapFrom(src => src.EmailAddress))
                .ForMember(
                    dest => dest.Phone,
                    opts => opts.MapFrom(src => src.PhoneNumber));

            CreateMap<Employee, EmployeeDto>()
                .ForMember(
                    dest => dest.EmailAddress,
                    opts => opts.MapFrom(src => src.Email))
                .ForMember(
                    dest => dest.PhoneNumber,
                    opts => opts.MapFrom(src => src.Phone));

        }
    }
}
