using core_web_api.Data;
using core_web_api.Models.Domain;
using core_web_api.Repositories.Interface;

namespace core_web_api.Repositories.implementation
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<Employee> CreateAsync(Employee employee) 
        {
            await _appDbContext.Employee.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();

            return employee;

        }
    }
}
