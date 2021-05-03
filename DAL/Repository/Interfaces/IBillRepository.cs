using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IBillRepository:IRepository<Bill,int>
    {
        /// <summary>
        /// Function to delete a Bill
        /// </summary>
        /// <param name="id">int id of Bill</param>
        /// <returns>bool</returns>
        bool Delete(int id);
        /// <summary>
        /// Function to update a Bill
        /// </summary>
        /// <param name="entity">Bill</param>
        /// <returns>Bill</returns>
        Bill Update(Bill entity);
    }
}
