using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Countries_Adapters.DepartmentsAdapter;

namespace MS_Countries_Adapters.MunicipalitiesAdapter
{
    public class CityAdapter : ICityAdapter
    {
        public async Task<City> CreateCity(City request)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                request.IdCity = 0;
                request.DateModified = DateTime.Now;
                db.Cities.Add(request);
                await db.SaveChangesAsync();
                return request;
            }
        }
        public async Task<List<City>> ReadCity()
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Cities.ToListAsync();
            }
        }
        public async Task<City> UpdateCity(City request)
        {
            City city = await ReadCity(request.IdCity);
            if (city != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    city.Active = request.Active;
                    city.NameCity = request.NameCity;
                    city.DateModified = DateTime.Now;
                    db.Entry(city).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    return city;
                }
            }
            return null;
        }
        public async Task<City> DeleteCity(short id)
        {
            City city = await ReadCity(id);
            if (city != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    db.Cities.Attach(city);
                    db.Cities.Remove(city);
                    await db.SaveChangesAsync();
                    return city;
                }
            }
            return null;
        }
        public async Task<City> ReadCity(short id)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Cities.FirstOrDefaultAsync(c => c.IdCity == id);
            }
        }
    
    }
}
