using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;
using Blazorfrontendsample.Services;
using Microsoft.AspNetCore.Components;


namespace Blazorfrontendsample
{
    public class EmployeePage
 {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}