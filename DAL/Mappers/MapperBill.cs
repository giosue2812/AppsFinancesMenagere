using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    /// <summary>
    /// Mapper to map a IDataRecord to Bill
    /// </summary>
    public static class MapperBill
    {
        /// <summary>
        /// Map IDataRecord to Bill
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>Bill</returns>
        public static Bill ToDalBill(this IDataRecord record)
        {
            if (record == null) return null;
            return new Bill
            {
                Id = (int)record["IdBill"],
                Balance = (decimal)record["Balance"],
                Deadline = (DateTime)record["Deadline"],
                PaymentDate = record["PaymentDate"] == DBNull.Value ? null : (DateTime)record["PaymentDate"],
                Postponement = record["Postponement"] == DBNull.Value ? null:(DateTime)record["Postponement"],
                Note = record["NOTE"] == DBNull.Value ? null: (string)record["NOTE"],
                IdOrganization = (int)record["IdOrganization"]
            };
        }
    }
}
