using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Countries_Adapters.MunicipalitiesAdapter
{
    public  interface IMunicipalityAdapter
    {
        Task<Municipality> CreateMunicipality(Municipality request);
        Task<List<Municipality>> ReadMunicipality();
        Task<Municipality> UpdateMunicipality(Municipality request);
        Task<Municipality> DeleteMunicipality(short id);
        Task<Municipality> ReadMunicipality(short id);
    }
}
}
