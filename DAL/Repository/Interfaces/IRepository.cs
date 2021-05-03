using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IRepository<TEntity, TKey> where TEntity:IEntity<TKey>
    {
        /// <summary>
        /// Function to Create a new Entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>int of id created</returns>
        int Create(TEntity entity);
        /// <summary>
        /// Function to Get an Entity from Tkey
        /// </summary>
        /// <param name="id">TKey</param>
        /// <returns>Entity</returns>
        TEntity Get(TKey Id);
        /// <summary>
        /// Function Abstract to GetAll Entity
        /// </summary>
        /// <returns>IEnumerable of Entity</returns>
        IEnumerable<TEntity> GetAll();
    }
}
