using EmployeeAdminPortal.Data.Repositories.Interfaces;
using EmployeeAdminPortal.Models.Entities;

namespace EmployeeAdminPortal.Data.Repositories
{
    public class EmployeeRepository(ApplicationDbContext context) : Repository<Employee>(context), IEmployeeRepository
    {
        public Task<Employee> CreateEmployee(Employee employee)
        {
            return this.CreateAsync(employee);
        }

        public Task<bool> DeleteEmployee(Guid id)
        {
            return this.DeleteAsync(id);
        }

        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return this.GetAllAsync();
        }

        public Task<Employee?> GetEmployeeById(Guid id)
        {
            return this.GetByIdAsync(id);
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            return this.UpdateAsync(employee);
        }
    }
}
