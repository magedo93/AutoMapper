using TestAutoMapper.Models;

namespace TestAutoMapper.Data
{
    public class DataSource : IDataSource
    {
        private readonly List<Employee> _employees = new List<Employee>()
        {
            new Employee() { Id = 1,Name="Ahmed" , Title ="Manager" , Image="image1.png"},
            new Employee() { Id = 2,Name="Mohamed" , Title ="HR" , Image="image2.png"},
            new Employee() { Id = 3,Name="Ali" , Title ="Employee" , Image="image3.png"},
            new Employee() { Id = 4,Name="Hassan" , Title ="Operation" , Image="image4.png"},
            new Employee() { Id = 5,Name="Zaki" , Title ="Data Entry" , Image="image5.png"},
            new Employee() { Id = 6,Name="Hossam" , Title ="Manager" , Image="image6.png"},
        };
        public Employee GetEmployee(int id)
        {
            return _employees.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmplyees()
        {
            return _employees;
        }
    }
}
