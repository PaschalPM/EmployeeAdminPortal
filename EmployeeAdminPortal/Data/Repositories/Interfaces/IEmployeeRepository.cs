using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> CreateEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> UpdateEmployee(Employee employee);
        Task<bool> DeleteEmployee(Guid id);
        Task<Employee?> GetEmployeeById(Guid id);
    }
}
