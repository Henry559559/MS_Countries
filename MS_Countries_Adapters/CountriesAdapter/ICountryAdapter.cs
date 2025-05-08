using System.Collections.Generic;
using System.Threading.Tasks;

namespace MS_Countries_Adapters.CountriesAdapter
{
    public interface ICountryAdapter
    {
        Task<Country> CreateCountries(Country request);
        Task<List<Country>> ReadCountries();
        Task<Country> UpdateCountries(Country request);
        Task<Country> DeleteCountry(short id);
        Task<Country> ReadCountry(short id);
    }
}
