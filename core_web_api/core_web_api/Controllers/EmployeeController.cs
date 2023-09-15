using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using core_web_api.Models.DTO;
using core_web_api.Models.Domain;
using System.Security.Cryptography.X509Certificates;
using core_web_api.Data;
using core_web_api.Repositories.Interface;
using core_web_api.Repositories.implementation;

namespace core_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeRequestDto request) 
        {
            //Map DTO to Domain Modal
            var employee = new Employee
            {
                emp_name = request.emp_name,
                emp_mail_id = request.emp_mail_id,
                emp_ph_no = request.emp_ph_no,
            };

            await _employeeRepository.CreateAsync(employee);

            //Domain to DTO
            var response = new EmployeeDto
            {
                ID = employee.ID,
                emp_mail_id = employee.emp_mail_id,
                emp_name = employee.emp_name,
                emp_ph_no = employee.emp_ph_no,
            };

            return Ok();
        }
    }
}
