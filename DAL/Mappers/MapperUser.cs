using DAL.Models;
using DAL.Models.Views;
using System;
using System.Data;

namespace DAL.Mappers
{
    public static class MapperUser
    {
        /// <summary>
        /// Convert an User to IDataRecord
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>User</returns>
        public static VUser ToDalUser(this IDataRecord record)
        {
            if (record == null) return null;
            return new VUser
            {
                Id = (int)record["IdUser"],
                BirthDate = (DateTime)record["BirthDate"],
                Email = (string)record["Email"],
                FirstName = (string)record["FirstName"],
                LastName = (string)record["LastName"],
                Tel = (string)record["tel"],
                IdRole = record["IdRole"] == DBNull.Value ? null : (int)record["IdRole"],
                IsActive = (bool)record["IsActive"],
                IdSensibleData = (int)record["IdSensibleData"]
            };
        }
    }
}
