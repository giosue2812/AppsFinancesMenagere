using DAL.Models;
using DAL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface ISensibleDataRepository : IRepository<SensibleData, VSensibleDataByOrganization, int>
    {
        /// <summary>
        /// Function to update a Sensible data
        /// </summary>
        /// <param name="entity">SensibleData</param>
        /// <returns>VSensibleDataByOrganization</returns
        VSensibleDataByOrganization Update(SensibleData entity);
    }
}
