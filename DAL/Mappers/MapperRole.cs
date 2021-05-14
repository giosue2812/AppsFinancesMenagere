using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class MapperRole
    {
        /// <summary>
        /// Convert a IdataRecor to Role
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>Role</returns>
        public static Role ToDalRole(this IDataRecord record)
        {
            if (record == null)return null;
            return new Role
            {
                Id = (int)record["IdRole"],
                RLabel = (string)record["RLabel"]
            };
        }
    }
}
