using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Countries_Adapters.MunicipalitiesAdapter
{
    public  interface ICityAdapter
    {
        Task<City> CreateCity(City request);
        Task<List<City>> ReadCity();
        Task<City> UpdateCity(City request);
        Task<City> DeleteCity(short id);
        Task<City> ReadCity(short id);
    }
}

