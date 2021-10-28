using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Blazorfrontendsample.Models;
using System.Net.Http.Json;

namespace Blazorfrontendsample
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var hasil = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return hasil;
        }

        public async Task<Employee> GetById(int id)
        {
            var hasil1 = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return hasil1;
        }
    }
}