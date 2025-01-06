using EmployeeAdminPortal.Models.Dtos.Requests;
using EmployeeAdminPortal.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(IEmployeeService employeeService) : ControllerBase
    {
        private readonly IEmployeeService _employeeService = employeeService;

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            return Ok(await _employeeService.GetAllEmployees());
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var newEmployee = await _employeeService.CreateEmployee(createEmployeeDto);
            return CreatedAtAction(nameof(GetEmployeeById), new { newEmployee.id }, newEmployee);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetEmployeeById(Guid id)
        {
            return Ok(await _employeeService.GetEmployeeById(id));
        }
        
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateEmployee(Guid id, UpdateEmplyeeDto updateEmplyeeDto)
        {
            return Ok(await _employeeService.UpdateEmployee(id, updateEmplyeeDto));
        }
        
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteEmployee(Guid id)
        {
            await _employeeService.DeleteEmployee(id);
            return NoContent();
        }
    }
}
