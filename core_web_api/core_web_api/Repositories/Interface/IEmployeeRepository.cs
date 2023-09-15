using core_web_api.Models.Domain;

namespace core_web_api.Repositories.Interface
{
    public interface IEmployeeRepository
    {
         Task<Employee> CreateAsync(Employee employee);
    }
}
