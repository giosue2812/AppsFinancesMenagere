
using DAL.Models.Views;
using System.Data;

namespace DAL.Mappers
{
    /// <summary>
    /// Mapper to map a IDataRecord to Dal Sensible data
    /// </summary>
    public static class MapperSensibleData
    {
        public static VSensibleDataByOrganization ToDalSensibleData(this IDataRecord record)
        {
            if (record == null) return null;
            return new VSensibleDataByOrganization
            {
                AddCountry = (string)record["AddCountry"],
                AddNumber = (string)record["AddNumber"],
                AddPostalCode = (string)record["AddPostalCode"],
                AddStreet = (string)record["AddStreet"],
                Id = (int)record["IdSensible"],
                IdOrganization = (int)record["IdOrganization"]
            };
        }
    }
}
