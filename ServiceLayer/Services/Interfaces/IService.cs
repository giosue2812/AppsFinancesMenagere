using ServiceLayer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IService<TBody,TEntity,TKey> where TEntity:IEntity<TKey>
    {
        /// <summary>
        /// Function to Create a new Entity
        /// </summary>
        /// <param name="body">New Entity</param>
        /// <returns>int id of Entity Created</returns>
        int Create(TBody body);
        /// <summary>
        /// Function to get a Entity
        /// </summary>
        /// <param name="Id">Tkey of id</param>
        /// <returns>TEntity</returns>
        TEntity Get(TKey Id);
        /// <summary>
        /// Function to get all Entity
        /// </summary>
        /// <returns>IEnumerable of Entity</returns>
        IEnumerable<TEntity> GetAll();
    }
}
