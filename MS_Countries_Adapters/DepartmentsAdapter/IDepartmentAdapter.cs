using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Countries_Adapters.DepartmentsAdapter
{
    public interface IDepartmentAdapter
    {
        Task<Department> CreateDepartment(Department request);
        Task<List<Department>> ReadDepartment();
        Task<Department> UpdateDepartment(Department request);
        Task<Department> DeleteDepartment(short id);
        Task<Department> ReadDepartment(short id);
    }
}
