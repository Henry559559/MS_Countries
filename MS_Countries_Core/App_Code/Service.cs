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
using MS_Countries_Adapters.MunicipalitiesAdapter;
using MS_Countries_Adapters.DepartmentsAdapter;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    #region Countries
    
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

    #endregion

    #region Departments


    private readonly IDepartmentAdapter _departmentAdapter = new DepartmentAdapter();

    public async Task<Department> CreateDepartments(Department request)
    {
        return await _departmentAdapter.CreateDepartment(request);
    }

    public async Task<List<Department>> ReadDepartments()
    {
        return await _departmentAdapter.ReadDepartment();
    }

    public async Task<Department> UpdateDepartments(Department request)
    {
        return await _departmentAdapter.UpdateDepartment(request);
    }

    public async Task<Department> DeleteDepartment(short id)
    {
        return await _departmentAdapter.DeleteDepartment(id);
    }

    public async Task<Department> ReadDepartment(short id)
    {
        return await _departmentAdapter.ReadDepartment(id);
    }

    #endregion

    #region Cities

    private readonly ICityAdapter _cityAdapter = new CityAdapter();

    public async Task<City> CreateCities(City request)
    {
        return await _cityAdapter.CreateCity(request);
    }

    public async Task<List<City>> ReadCities()
    {
        return await _cityAdapter.ReadCity();
    }

    public async Task<City> UpdateCities(City request)
    {
        return await _cityAdapter.UpdateCity(request);
    }

    public async Task<City> DeleteCity(short id)
    {
        return await _cityAdapter.DeleteCity(id);
    }

    public async Task<City> ReadCity(short id)
    {
        return await _cityAdapter.ReadCity(id);
    }

    #endregion
}
