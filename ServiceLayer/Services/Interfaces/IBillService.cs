using ServiceLayer.Models;
using ServiceLayer.Models.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBillService:IService<BillForm,Bill,int>
    {
        /// <summary>
        /// Function to update a Bill
        /// </summary>
        /// <param name="bill">Bill to update</param>
        /// <returns>Bill</returns>
        Bill Update(BillUpdate bill);
        /// <summary>
        /// Function to delete a Bill
        /// </summary>
        /// <param name="Id">int of bill to delete</param>
        /// <returns>bool</returns>
        bool Delete(int Id);
    }
}
