using ServiceLayer.Models;
using ServiceLayer.Models.Form.Bills;
using ServiceLayer.Models.Views;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBillService:IService<BillForm,VBillWithOrganization,int>
    {
        /// <summary>
        /// Function to update a Bill
        /// </summary>
        /// <param name="bill">Bill to update</param>
        /// <returns>Bill</returns>
        VBillWithOrganization Update(BillUpdate bill);
        /// <summary>
        /// Function to delete a Bill
        /// </summary>
        /// <param name="Id">int of bill to delete</param>
        /// <returns>bool</returns>
        bool Delete(int Id);
        /// <summary>
        /// Functon to pay a Bill
        /// </summary>
        /// <param name="id">Int id of Bill</param>
        /// <returns></returns>
        bool Payement(int id);
        /// <summary>
        /// Function to Add a DatePostponement
        /// </summary>
        /// <param name="form">BillDatePostponement</param>
        /// <returns>bool</returns>
        bool DatePostponement(BillDatePostponement form);
    }
}
