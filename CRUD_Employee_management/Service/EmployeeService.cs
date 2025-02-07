using CRUD_Employee_management.Models;
using CRUD_Employee_management.Repository;

namespace CRUD_Employee_management.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository) {
        
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            return await _employeeRepository.CreateEmployeeAsync(employee);
        }
        public Task DeleteEmployeeAsync(int id)
        {
            return _employeeRepository.DeleteEmployeeAsync(id);
        }
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }
        public Task UpdateEmployeeAsync(Employee employee)
        {
            return _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
