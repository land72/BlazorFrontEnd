using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Blazorfrontendsample.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System;

namespace Blazorfrontendsample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
                public Task<Employee> Add(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var hasil = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("/api/Employees");
            return hasil;
        }

        public async Task<Employee> GetById(int id)
        {
            var hasil1 = await _httpClient.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
            return hasil1;
        }
      
        public async Task<Employee> Update(int id, Employee employee)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Employees/{id}",employee);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("Gagal update Employee");
            }
        }
    }
}