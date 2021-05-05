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
        public static S.Bill ToServiceLayer (this D.Bill entity)
        {
            if (entity == null) return null;
            return new S.Bill
            {
                Id = entity.Id,
                Balance = entity.Balance,
                Deadline = entity.Deadline,
                Note = entity.Note,
                IdOrganization = entity.IdOrganization,
                PaymentDate = entity.PaymentDate,
                Postponement = entity.Postponement
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
    }
}
