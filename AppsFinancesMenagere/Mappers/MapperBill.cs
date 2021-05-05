﻿using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    public static class MapperBill
    {
        /// <summary>
        /// Mapper to ServiceLayer Bill to Api BillGet
        /// </summary>
        /// <param name="bill">ServiceLayer Bill</param>
        /// <returns>Api BillGet</returns>
        public static A.BillGet ToApi(this S.Bill bill)
        {
            if (bill == null) return null;
            return new A.BillGet
            {
                Id = bill.Id,
                Balance = bill.Balance,
                Deadline = bill.Deadline,
                IdOrganization = bill.IdOrganization,
                Note = bill.Note,
                PaymentDate = bill.PaymentDate,
                Postponement = bill.Postponement
            };
        }
        /// <summary>
        /// Mapper to Api BillGet to ServiceLayer Bill
        /// </summary>
        /// <param name="bill">Api BillUpdate</param>
        /// <returns>ServiceLayer BillUpdate</returns>
        public static S.Form.Bills.BillUpdate ToServiceLayers(this A.Form.Bills.BillUpdate bill)
        {
            if (bill == null) return null;
            return new S.Form.Bills.BillUpdate
            {
                Id = bill.Id,
                Balance = bill.Balance,
                Deadline = bill.Deadline,
                Note = bill.Note,
                IdOrganization = bill.IdOrganization
            };
        }
        /// <summary>
        /// Mapper to Api BillForm to ServiceLayer BillForm
        /// </summary>
        /// <param name="billForm"></param>
        /// <returns></returns>
        public static S.Form.Bills.BillForm ToServiceLayer(this A.Form.Bills.BillForm billForm)
        {
            if (billForm == null) return null;
            return new S.Form.Bills.BillForm
            {
                Balance = billForm.Balance,
                Deadline = billForm.Deadline,
                Note = billForm.Note
            };
        }
    }
}
