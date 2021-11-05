using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;

namespace Blazorfrontendsample.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
    }
}