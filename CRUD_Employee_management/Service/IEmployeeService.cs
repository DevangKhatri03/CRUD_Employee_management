using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_Employee_management;
using CRUD_Employee_management.Models;

namespace CRUD_Employee_management.Service
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> CreateEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);
    }
}
