using DAL.Models;
using DAL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IOrganizationRepository:IRepository<Organization,VOrganization,int>
    {
        /// <summary>
        /// Function to delete a Bill
        /// </summary>
        /// <param name="id">int id of Bill</param>
        /// <returns>bool</returns>
        bool SwitchIsActive(int Id);
        /// <summary>
        /// Function to Update a organization
        /// </summary>
        /// <param name="entity">Organization</param>
        /// <returns>Organization</returns>
        VOrganization Update(Organization entity);
    }
}
