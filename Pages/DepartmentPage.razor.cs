using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;
using Blazorfrontendsample.Services;
using Microsoft.AspNetCore.Components;


namespace Blazorfrontendsample.Pages
{
    public class DepartmentPage
 {
        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}