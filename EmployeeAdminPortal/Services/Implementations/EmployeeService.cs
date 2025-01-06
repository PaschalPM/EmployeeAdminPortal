using AutoMapper;
using EmployeeAdminPortal.Data.Repositories.Interfaces;
using EmployeeAdminPortal.Exceptions;
using EmployeeAdminPortal.Models.Dtos.Requests;
using EmployeeAdminPortal.Models.Dtos.Responses;
using EmployeeAdminPortal.Models.Entities;
using EmployeeAdminPortal.Services.Interfaces;

namespace EmployeeAdminPortal.Services.Implementations
{
    public class EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper) : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository = employeeRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<EmployeeDto> CreateEmployee(CreateEmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            var authCode = (new Random().Next(100000000, int.MaxValue)).ToString();
            employee.AuthCode = authCode;
            await _employeeRepository.CreateEmployee(employee);
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task DeleteEmployee(Guid id)
        {
            var isDeleted = await _employeeRepository.DeleteEmployee(id);

            if (!isDeleted) {
                throw new NotFoundHttpException($"Employee({id}) Not found");
            }
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployees()
        {
            var allEmployees = await _employeeRepository.GetAllEmployees();
            return allEmployees.Select(employee => _mapper.Map<EmployeeDto>(employee));
        }

        public async Task<EmployeeDto> GetEmployeeById(Guid id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id) ?? throw new NotFoundHttpException($"Employee({id}) Not found");
            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task<EmployeeDto> UpdateEmployee(Guid id, UpdateEmplyeeDto updateEmployeeDto)
        {
            var employee = await _employeeRepository.GetEmployeeById(id) ?? throw new NotFoundHttpException($"Employee({id}) Not found");
            var updatedEmployee = _mapper.Map(updateEmployeeDto, employee);
            return _mapper.Map<EmployeeDto>(await _employeeRepository.UpdateEmployee(updatedEmployee));
        }
    }
}
