using S = ServiceLayer.Models;
using D = DAL.Models;

namespace ServiceLayer.Mappers
{
    public static class MapperBill
    {
        /// <summary>
        /// Map Dal Bill to ServiceLayer Bill
        /// </summary>
        /// <param name="entity">Dal Bill</param>
        /// <returns>ServiceLayer Bill</returns>
        public static S.Views.VBillWithOrganization ToServiceLayer(this D.Views.VBillWithOrganization entity)
        {
            if (entity == null) return null;
            return new S.Views.VBillWithOrganization
            {
                Id = entity.Id,
                Balance = entity.Balance,
                Deadline = entity.Deadline,
                Note = entity.Note,
                IdOrganization = entity.IdOrganization,
                PaymentDate = entity.PaymentDate,
                Postponement = entity.Postponement,
                Organization = entity.Organization,
                OrName = entity.OrName
            };
        }
        /// <summary>
        /// Map ServiceLayer BillForm to Dal Bill
        /// </summary>
        /// <param name="bill">ServiceLayer BillForm</param>
        /// <returns>Dal Bill</returns>
        public static D.Bill ToDal(this S.Form.Bills.BillForm bill)
        {
            if (bill == null) return null;
            return new D.Bill
            {
                Balance = bill.Balance,
                Deadline = bill.Deadline,
                Note = bill.Note
            };
        }
        /// <summary>
        /// Map ServiceLayer Bill to Dal Bill
        /// </summary>
        /// <param name="bill">ServiceLayer Bill</param>
        /// <returns>Dal Bill</returns>
        public static D.Bill ToDal(this S.Form.Bills.BillUpdate bill)
        {
            if (bill == null) return null;
            return new D.Bill
            {
                Id = bill.Id,
                Balance = bill.Balance,
                Deadline = bill.Deadline,
                Note = bill.Note
            };
        }
        /// <summary>
        /// Map ServiceLayer to Dal BillDatePostponement 
        /// </summary>
        /// <param name="bill">ServiceLayer BillDatePostponement</param>
        /// <returns>Dal BillDatePostponement</returns>
        public static D.Form.BillDatePostponement ToDal(this S.Form.Bills.BillDatePostponement bill)
        {
            if (bill == null) return null;
            return new D.Form.BillDatePostponement
            {
                Id = bill.Id,
                DatePostponement = bill.DatePostponement
            };
        }
    }
}
