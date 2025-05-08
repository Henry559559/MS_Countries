using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MS_Countries_Adapters.CountriesAdapter
{
    public class CountryAdapter : ICountryAdapter
    {
        public async Task<Country> CreateCountries(Country request)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                request.IdCountry = 0;
                request.DateModified = DateTime.Now;
                db.Countries.Add(request);
                await db.SaveChangesAsync();
                return request;
            }
        }

        public async Task<List<Country>> ReadCountries()
        {
            using(CountriesEntities db = new CountriesEntities())
            {
                return await db.Countries.ToListAsync();
            }
        }

        public async Task<Country> UpdateCountries(Country request)
        {
            Country country = await ReadCountry(request.IdCountry);
            if (country != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    country.Active = request.Active;
                    country.NameCountry = request.NameCountry;
                    country.DateModified = DateTime.Now;
                    db.Entry(country).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    return country;
                }
            }
            return null;
        }

        public async Task<Country> DeleteCountry(short id)
        {
            Country country = await ReadCountry(id);
            if (country != null)
            {
                using (CountriesEntities db = new CountriesEntities())
                {
                    db.Countries.Attach(country);
                    db.Countries.Remove(country);
                    await db.SaveChangesAsync();
                    return country;
                }
            }
            return null;
        }

        public async Task<Country> ReadCountry(short id)
        {
            using (CountriesEntities db = new CountriesEntities())
            {
                return await db.Countries.FirstOrDefaultAsync(c => c.IdCountry == id);
            }
        }
    }
}
