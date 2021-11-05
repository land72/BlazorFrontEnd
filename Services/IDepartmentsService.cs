using System.Collections.Generic;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazorfrontendsample.Models;


namespace Blazorfrontendsample.Services
{
    public interface IDepartmentsService
    {
         Task<IEnumerable<Department>> GetAll();
         Task<Department> GetById(int id);
    }
}