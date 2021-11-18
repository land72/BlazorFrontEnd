using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;
using Blazorfrontendsample.Services;
using Microsoft.AspNetCore.Components;

namespace Blazorfrontendsample.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject ]

           public IEmployeeService EmployeeService { get; set; }

           [Inject]
        public IDepartmentsService DepartmentsService { get; set; }

         [Inject]
        public NavigationManager NavigationManager { get; set; }

         public List<Department> Departments { get; set; } = new List<Department>();
        [Parameter]


           public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetById(int.Parse(Id));
            Departments = (await DepartmentsService.GetAll()).ToList();
        }

        protected async Task HandleValidSubmit(){
           Employee result = await EmployeeService.Update(int.Parse(Id),Employee);
           NavigationManager.NavigateTo("employeepage");
        }

    }
}