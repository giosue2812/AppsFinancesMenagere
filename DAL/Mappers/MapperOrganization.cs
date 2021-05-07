using DAL.Models;
using DAL.Models.Views;
using System;
using System.Data;

namespace DAL.Mappers
{
    /// <summary>
    /// Mapper to map a IDataRecord to Organization
    /// </summary>
    public static class MapperOrganization
    {
        /// <summary>
        /// Map IDataRecord to Organization
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>VBillWithOrganization</returns>
        public static VOrganization ToDal(this IDataRecord record)
        {
            if (record == null) return null;
            return new VOrganization
            {
                Id = (int)record["IdOrganization"],
                OrName = (string)record["OrName"],
                TypeOrganization = (string)record["Organization"],
                Tel1 = record["Tel1"] == DBNull.Value ? null : (string)record["Tel1"],
                Tel2 = record["Tel2"] == DBNull.Value ? null : (string)record["Tel2"],
                Email = record["Email"] == DBNull.Value ? null : (string)record["Email"],
                NameContact = record["NameContact"] == DBNull.Value ? null : (string)record["NameContact"],
                IsActive = (bool)record["IsActive"]
            };
        }
    }
}
