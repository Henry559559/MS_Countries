using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Countries_Adapters.DepartmentsAdapter
{
    public  class DepartmentAdapter :IDepartmentAdapter 
    {
        public async Task<Department> CreateDepartment(Department request)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                request.IdDepartment = 0;
                request.DateModified = DateTime.Now;
                db.Departments.Add(request);
                await db.SaveChangesAsync();
                return request;
            }
        }

        public async Task<List<Department>> ReadDepartment()
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Departments.ToListAsync();
            }
        }

        public async Task<Department> UpdateDepartment(Department request)
        {
            Department department = await ReadDepartment(request.IdDepartment);
            if (department != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    department.Active = request.Active;
                    department.NameDepartment = request.NameDepartment;
                    department.DateModified = DateTime.Now;
                    db.Entry(department).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    return department;
                }
            }
            return null;
        }

        public async Task<Department> DeleteDepartment(short id)
        {
            Department department = await ReadDepartment(id);
            if (department != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    db.Departments.Attach(department);
                    db.Departments.Remove(department);
                    await db.SaveChangesAsync();
                    return department;
                }
            }
            return null;
        }

        public async Task<Department> ReadDepartment(short id)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Departments.FirstOrDefaultAsync(c => c.IdDepartment == id);
            }
        }
    }
}
