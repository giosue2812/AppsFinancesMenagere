using DAL.Mappers;
using DAL.Models;
using DAL.Models.Form;
using DAL.Models.Views;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL.Repository
{
    /// <summary>
    /// Class to describe a Bill Repository
    /// </summary>
    public class BillRepository : RepositoryBase<Bill,VBillWithOrganization,int>,IBillRepository
    {
        public override IEnumerable<VBillWithOrganization> GetAll()
        {
            Command command = new Command("SELECT * FROM V_BillWithOrganization");
            return Connection.ExecuteReader(command, (b) => b.ToDalBill());
        }

        public override VBillWithOrganization Get(int Id)
        {
            Command command = new Command("SELECT * FROM V_BillWithOrganization WHERE IdBill = @id");
            command.AddParameter("@Id", Id);
            return Connection.ExecuteReader(command,(b)=>b.ToDalBill()).SingleOrDefault();
        }

        public override int Create(Bill entity)
        {
            Command command = new Command("P_AddBill", true);
            command.AddParameter("@Balance", entity.Balance);
            command.AddParameter("@Deadline", entity.Deadline);
            command.AddParameter("@Note", entity.Note);
            command.AddParameter("@IdOrganization",entity.IdOrganization);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentException("Error raise during insertion");
            else return idCreated;
        }
        /// <summary>
        /// Function to update a Bill
        /// </summary>
        /// <param name="entity">Bill</param>
        /// <returns>Bill</returns>
        public VBillWithOrganization Update(Bill entity)
        {
            Command command = new Command("P_UpdateBill", true);
            command.AddParameter("@IdBill", entity.Id);
            command.AddParameter("@Balance", entity.Balance);
            command.AddParameter("@Deadline", entity.Deadline);
            command.AddParameter("@Note", entity.Note);
            command.AddParameter("@IdOrganization", entity.IdOrganization);
            VBillWithOrganization bill = Connection.ExecuteReader(command,(b)=>b.ToDalBill()).SingleOrDefault();
            if (bill == null) throw new ArgumentException("Error raise during Update or Bill not find");
            return bill;
        }
        /// <summary>
        /// Function to delete a Bill
        /// </summary>
        /// <param name="id">int id of Bill</param>
        /// <returns>bool</returns>
        public bool Delete(int Id)
        {
            Command command = new Command("P_DeleteBill", true);
            command.AddParameter("@IdBill",Id);
            bool isDeleted = Connection.ExecuteNonQuery(command) == 1;
            if (!isDeleted) throw new ArgumentNullException("Error raise during deletion or Bill not found");
            else return isDeleted;
        }
        /// <summary>
        /// Function to pay a Bill
        /// </summary>
        /// <param name="Id">int Id of Bill</param>
        /// <returns>bool</returns>
        public bool Payement(int Id)
        {
            Command command = new Command("P_BillPayement", true);
            command.AddParameter("@IdBill", Id);
            bool isPay = Connection.ExecuteNonQuery(command) == 1;
            if (!isPay) throw new ArgumentNullException("Error raise during update or Bill not found");
            else return isPay;
        }
        /// <summary>
        /// Function to add a Date Postponement
        /// </summary>
        /// <param name="form">BillDatePostponement</param>
        /// <returns>bool</returns>
        public bool DatePostponement(BillDatePostponement form)
        {
            Command command = new Command("P_Postponement", true);
            command.AddParameter("@IdBill", form.Id);
            command.AddParameter("@Date", form.DatePostponement);
            bool isChange = Connection.ExecuteNonQuery(command) == 1;
            if (!isChange) throw new ArgumentNullException("Error raise during update or Bill not found");
            else return isChange;
        }
    }
}
