using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestAutoMapper.Data;
using TestAutoMapper.Dtos;

namespace TestAutoMapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(IDataSource dataSource,IMapper mapper)
        {
            DataSource = dataSource;
            this.mapper = mapper;
        }

        private IDataSource DataSource;
        private readonly IMapper mapper;

        [HttpGet]
        public EmployeeDto GetEmployee(int id)
        {
            var empModel= DataSource.GetEmployee(id);
            var empDto = mapper.Map<EmployeeDto>(empModel);
            return empDto;
        }
        [HttpGet]
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            var empList= DataSource.GetEmplyees();
            var empDtoList = mapper.Map<List<EmployeeDto>>(empList);
            return empDtoList;
        }
    }
}
