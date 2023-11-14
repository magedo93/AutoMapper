using TestAutoMapper.Models;

namespace TestAutoMapper.Data
{
    public interface IDataSource
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmplyees();
    }
}
