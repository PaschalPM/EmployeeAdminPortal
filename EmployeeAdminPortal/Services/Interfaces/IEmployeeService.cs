using EmployeeAdminPortal.Models.Dtos.Requests;
using EmployeeAdminPortal.Models.Dtos.Responses;
using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployees();
        Task<EmployeeDto> GetEmployeeById(Guid id);
        Task<EmployeeDto> CreateEmployee(CreateEmployeeDto employeeDto);
        Task<EmployeeDto> UpdateEmployee(Guid id, UpdateEmplyeeDto employeeDto);
        Task DeleteEmployee(Guid id);
    }
}
