using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    /// <summary>
    /// Mapper to map Organization Api to Service Layer
    /// </summary>
    public static class MapperOrganization
    {
        /// <summary>
        /// Convert ServiceLayer VOrganization to Api OrganisationGet
        /// </summary>
        /// <param name="entity">ServiceLayer VOrganization</param>
        /// <returns>Api OrganizationGet</returns>
        public static A.OrganizationGet ToApi(this S.Views.VOrganisation entity)
        {
            if (entity == null) return null;
            return new A.OrganizationGet
            {
                Id = entity.Id,
                Email = entity.Email,
                NameContact = entity.NameContact,
                OrName = entity.OrName,
                Tel1 = entity.Tel1,
                Tel2 = entity.Tel2,
                TypeOrganization = entity.TypeOrganization,
                IsActive = entity.IsActive
                
            };
        }
        /// <summary>
        /// Convert Api OrganizationForm to ServiceLayer OrganizationForm
        /// </summary>
        /// <param name="form">API OrganizationForm</param>
        /// <returns>ServiceLayer OrganizationForm</returns>
        public static S.Form.Organizations.OrganizationForm ToServiceLayer(this A.Form.Organizations.OrganizationForm form)
        {
            if (form == null) return null;
            return new S.Form.Organizations.OrganizationForm
            {
                Email = form.Email,
                NameContact = form.NameContact,
                Organization = form.Organization,
                OrName = form.OrName,
                Tel1 = form.Tel1,
                Tel2 = form.Tel2
            };
        }
        /// <summary>
        /// Convert Api OrganizationUpdate to ServiceLayer OrganizationForm
        /// </summary>
        /// <param name="form">Api OrganizationUpdate</param>
        /// <returns>ServiceLayer OrganizationUpdate</returns>
        public static S.Form.Organizations.OrganizationUpdate ToServiceLayer(this A.Form.Organizations.OrganizationUpdate form)
        {
            if (form == null) return null;
            return new S.Form.Organizations.OrganizationUpdate
            {
                Email = form.Email,
                Id = form.Id,
                NameContact = form.NameContact,
                Organization = form.Organization,
                OrName = form.OrName,
                Tel1 = form.Tel1,
                Tel2 = form.Tel2
            };
        }
    }
}
