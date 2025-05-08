using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Countries_Adapters.DepartmentsAdapter;

namespace MS_Countries_Adapters.MunicipalitiesAdapter
{
    public class MunicipalityAdapter : IMunicipalityAdapter
    {
        public async Task<Municipality> CreateMunicipality(Municipality request)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                request.IdMunicipality = 0;
                request.DateModified = DateTime.Now;
                db.Municipalities.Add(request);
                await db.SaveChangesAsync();
                return request;
            }
        }
        public async Task<List<Municipality>> ReadMunicipality()
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Municipalities.ToListAsync();
            }
        }
        public async Task<Municipality> UpdateMunicipality(Municipality request)
        {
            Municipality municipality = await ReadMunicipality(request.IdMunicipality);
            if (municipality != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    municipality.Active = request.Active;
                    municipality.NameMunicipality = request.NameMunicipality;
                    municipality.DateModified = DateTime.Now;
                    db.Entry(municipality).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    return municipality;
                }
            }
            return null;
        }
        public async Task<Municipality> DeleteMunicipality(short id)
        {
            Municipality municipality = await ReadMunicipality(id);
            if (municipality != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    db.Municipalities.Attach(municipality);
                    db.Municipalities.Remove(municipality);
                    await db.SaveChangesAsync();
                    return municipality;
                }
            }
            return null;
        }
        public async Task<Municipality> ReadMunicipality(short id)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Municipalities.FirstOrDefaultAsync(c => c.IdMunicipality == id);
            }
        }
    
    }
}
