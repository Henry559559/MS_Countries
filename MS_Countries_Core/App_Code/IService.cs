using System.Collections.Generic;
using System.ServiceModel;
using MS_Countries_Adapters;
using System.Threading.Tasks;

[ServiceContract]
public interface IService
{
    #region Countries

    [OperationContract]
    Task<Country> CreateCountries(Country request);

    [OperationContract]
    Task<List<Country>> ReadCountries();

    [OperationContract]
    Task<Country> UpdateCountries(Country request);

    [OperationContract]
    Task<Country> DeleteCountry(short id);

    [OperationContract]
    Task<Country> ReadCountry(short id);

    #endregion

    #region Departments

    [OperationContract]
    Task<Department> CreateDepartments(Department request);

    [OperationContract]

    Task<List<Department>> ReadDepartments();

    [OperationContract]
    Task<Department> UpdateDepartments(Department request);

    [OperationContract]

    Task<Department> DeleteDepartment(short id);

    [OperationContract]

    Task<Department> ReadDepartment(short id);

    #endregion


    #region Cities

    [OperationContract]

    Task<City> CreateCities(City request);

    [OperationContract]

    Task<List<City>> ReadCities();

    [OperationContract]
    Task<City> UpdateCities(City request);

    [OperationContract]

    Task<City> DeleteCity(short id);

    [OperationContract]

    Task<City> ReadCity(short id);
    
    #endregion

}

//[DataContract]
//public class CompositeType
//{
//	bool boolValue = true;
//	string stringValue = "Hello ";

//	[DataMember]
//	public bool BoolValue
//	{
//		get { return boolValue; }
//		set { boolValue = value; }
//	}

//	[DataMember]
//	public string StringValue
//	{
//		get { return stringValue; }
//		set { stringValue = value; }
//	}
//}
