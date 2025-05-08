using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MS_Countries_Adapters.CountriesAdapter;
using MS_Countries_Adapters;
using System.Threading.Tasks;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    private readonly ICountryAdapter _countryAdapter = new CountryAdapter();

    public async Task<Country> CreateCountries(Country request)
    {
        return await _countryAdapter.CreateCountries(request);
    }

    public async Task<List<Country>> ReadCountries()
    {
        return await _countryAdapter.ReadCountries();
    }

    public async Task<Country> UpdateCountries(Country request)
    {
        return await _countryAdapter.UpdateCountries(request);
    }

    public async Task<Country> DeleteCountry(short id)
    {
        return await _countryAdapter.DeleteCountry(id);
    }

    public async Task<Country> ReadCountry(short id)
    {
        return await _countryAdapter.ReadCountry(id);
    }
}
