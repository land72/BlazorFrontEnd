using System.Reflection.Metadata;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;
using Blazorfrontendsample.Services;
using Microsoft.AspNetCore.Components;

namespace Blazorfrontendsample.Pages
{
    public partial class DetailDepartment
    {
        [Parameter]
        public string id { get; set; }
       public Department Department { get; set; }
        [Inject]
        public IDepartmentsService DepartmentService { get; set; }

     protected override async Task OnInitializedAsync()
     {
         id = id ?? "1"; 
         Department = await DepartmentService.GetById(int.Parse(id)); 
     }




    }
}