using System.Reflection.Metadata;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;
using Blazorfrontendsample.Services;
using Microsoft.AspNetCore.Components;

namespace Blazorfrontendsample.Pages
{
    public partial class DetailEmployee
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "7";
            Employee = await EmployeeService.GetById(int.Parse(id));
        }
    }
}