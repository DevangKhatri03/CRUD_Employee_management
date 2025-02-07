using System.Net;
using System.Net.Http.Json;
using CRUD_Employee_management.Models;

namespace FrontEnd.Services

{
    public class EmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Get all employees
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _httpClient.GetFromJsonAsync<List<Employee>>("Employee");
            return employees;
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await _httpClient.GetFromJsonAsync<Employee>($"Employee/{id}");
            return employee;
        }
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var response = await _httpClient.PostAsJsonAsync("Employee", employee);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Employee>();
        }
        public async Task<Employee> UpdateEmployee(int id, Employee employee)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/employees/{id}", employee);
            response.EnsureSuccessStatusCode();
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return null; 
            }
            return await response.Content.ReadFromJsonAsync<Employee>();
        }

        public async Task DeleteEmployee(int id)
        {
            var response = await _httpClient.DeleteAsync($"Employee/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
