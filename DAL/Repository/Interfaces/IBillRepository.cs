using DAL.Models;
using DAL.Models.Form;
using DAL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IBillRepository:IRepository<Bill,VBillWithOrganization,int>
    {
        /// <summary>
        /// Function to add a Date Postponement
        /// </summary>
        /// <param name="form">BillDatePostponement</param>
        /// <returns>bool</returns>
        bool DatePostponement(BillDatePostponement form);

        /// <summary>
        /// Function to delete a Bill
        /// </summary>
        /// <param name="id">int id of Bill</param>
        /// <returns>bool</returns>
        bool Delete(int id);
        /// <summary>
        /// Function to pay a Bill
        /// </summary>
        /// <param name="Id">int Id of Bill</param>
        /// <returns>bool</returns>
        bool Payement(int Id);

        /// <summary>
        /// Function to update a Bill
        /// </summary>
        /// <param name="entity">Bill</param>
        /// <returns>Bill</returns>
        VBillWithOrganization Update(Bill entity);
    }
}
