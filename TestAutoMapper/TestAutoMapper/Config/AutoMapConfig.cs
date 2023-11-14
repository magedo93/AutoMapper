using AutoMapper;
using TestAutoMapper.Dtos;
using TestAutoMapper.Models;

namespace TestAutoMapper.Config
{
    public class AutoMapConfig : Profile
    {
        public AutoMapConfig() {

            CreateMap<Employee, EmployeeDto>();
        }
    }
}
