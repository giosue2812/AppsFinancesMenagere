using DAL.Models;
using DAL.Models.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class MapperAccount
    {
        /// <summary>
        /// Convert IDataRecord to Account
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>Account</returns>
        public static Account ToDalAccount(this IDataRecord record)
        {
            if (record == null) return null;
            return new Account
            {
                AccountNumber = (string)record["Account"],
                Balance = (decimal)record["Balance"],
                CreationDate = (DateTime)record["CreationDate"],
                Id = (int)record["IdAccount"],
                IdMandatary = record["IdMandatary"] == DBNull.Value ? null : (int)record["IdMandatary"],
                IdTitular = (int)record["IdTitular"],
                IsActive = (bool)record["IsActive"],
                Note = record["Note"] == DBNull.Value ? null : (string)record["Note"]
            };
        }

        public static VAccountByTitular ToDalAccountByTitular(this IDataRecord record)
        {
            if (record == null) return null;
            return new VAccountByTitular
            {
                Account = (string)record["Account"],
                Balance = (decimal)record["Balance"],
                IdTitular = (int)record["IdTitular"],
                Note = (string)record["Note"]
            };
        }
        public static VAccountByMandatary ToDalAccountByMandatary(this IDataRecord record)
        {
            if (record == null) return null;
            return new VAccountByMandatary
            {
                Account = (string)record["Account"],
                Balance = (decimal)record["Balance"],
                IdManadatary = (int)record["IdMandatary"],
                Note = (string)record["Note"]
            };
        }
    }
}
