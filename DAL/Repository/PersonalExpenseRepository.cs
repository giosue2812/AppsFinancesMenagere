using DAL.Models;
using System;
using System.Collections.Generic;
using DAL.Mappers;
using Tool.Connection.DB;
using DAL.Repository.Interfaces;
using System.Linq;
using DAL.Models.Form;

namespace DAL.Repository
{
    public class PersonalExpenseRepository : RepositoryBase<PersonalExpenseForm, PersonalExpense, int>,IPersonalExpenseRepository
    {
        public override IEnumerable<PersonalExpense> GetAll()
        {
            Command command = new Command("SELECT * FROM V_PersonalExpense");
            return Connection.ExecuteReader(command,(p=>p.ToDalPersonalExpense()));
        }
        public override PersonalExpense Get(int Id)
        {
            throw new NotImplementedException();
        }
        public override int Create(PersonalExpenseForm entity)
        {
            Command command = new Command("P_AddPersonalExpense", true);
            command.AddParameter("@IdAccount", entity.IdAcount);
            command.AddParameter("@IdUser", entity.IdUser);
            command.AddParameter("@Balance", entity.Balance);
            command.AddParameter("@DateExpense", entity.DateExpense);
            command.AddParameter("@Elabel", entity.ELabel);
            int idCreated = (int)Connection.ExecuteScalar(command);
            if (idCreated == 0) throw new ArgumentException("Error raise during insertion");
            else return idCreated;
        }
        public IEnumerable<PersonalExpense> GetExpenseByUser(int Id)
        {
            Command command = new Command("P_GetExpenseByUser", true);
            command.AddParameter("@IdUser", Id);
            return Connection.ExecuteReader(command, (p => p.ToDalPersonalExpense()));
        }
            
    }
}
