using ServiceLayer.Models.Form.Organizations;
using ServiceLayer.Models.Views;
using S = ServiceLayer.Models;

namespace ServiceLayer.Services.Interfaces
{
    public interface IOrganizationService : IService<S.Form.Organizations.OrganizationForm, S.Views.VOrganisation, int>
    {
        /// <summary>
        /// Function to Switch a IsActive
        /// </summary>
        /// <param name="Id">Int id of Organization</param>
        /// <returns>bool</returns>
        bool SwitchIsActive(int Id);
        /// <summary>
        /// Function to update an Organization
        /// </summary>
        /// <param name="body">OrganizationUpdate</param>
        /// <returns>VOrganisation</returns>
        VOrganisation Update(OrganizationUpdate body);
    }
}
