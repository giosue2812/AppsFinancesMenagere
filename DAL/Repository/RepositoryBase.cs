using DAL.Models.Interfaces;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL.Repository
{
    /// <summary>
    /// Class to describe a Repository Base
    /// </summary>
    /// <typeparam name="TEntity">Type Entity</typeparam>
    /// <typeparam name="TKey">Type Key</typeparam>
    public abstract class RepositoryBase<TBody,TEntity,TKey>: IRepository<TBody,TEntity,TKey> where TEntity:IEntity<TKey>
    {
        protected Connection Connection { get; }
        public RepositoryBase()
        {
            Connection = new Connection(SqlClientFactory.Instance, "Data Source=DESKTOP-0E0AMEL;Initial Catalog=FinancesMenagers;Integrated Security=True;");
        }
        /// <summary>
        /// Function Abstract to GetAll Entity
        /// </summary>
        /// <returns>IEnumerable of Entity</returns>
        public abstract IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Function to Get an Entity from Tkey
        /// </summary>
        /// <param name="id">TKey</param>
        /// <returns>Entity</returns>
        public abstract TEntity Get(TKey Id);
        /// <summary>
        /// Function to Create a new Entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>int of id created</returns>
        public abstract int Create(TBody entity);
    }
}
