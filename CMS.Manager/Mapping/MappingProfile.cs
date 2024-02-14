using AutoMapper;
using CMS.Entities.Models;
using CMS.Shared.DataTransferObjects;

namespace CMS.Manager.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
  .ForCtorParam("FullAddress",
  opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>();
        }
    }
}
