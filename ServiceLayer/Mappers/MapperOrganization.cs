using D = DAL.Models;
using S = ServiceLayer.Models;

namespace ServiceLayer.Mappers
{
    /// <summary>
    /// Mapper to ServiceLayer Organization and Dal Organization
    /// </summary>
    public static class MapperOrganization
    {
        /// <summary>
        /// Convert Dal VOrganization to ServiceLayer VOrganization
        /// </summary>
        /// <param name="entity">Dal VOrganization</param>
        /// <returns>ServiceLayer VOrganization</returns>
        public static S.Views.VOrganisation ToServiceLayer(this D.Views.VOrganization entity)
        {
            if (entity == null) return null;
            return new S.Views.VOrganisation
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
        /// Convert ServiceLayer OrganizationForm to Dal Organization
        /// </summary>
        /// <param name="form">ServiceLayer OrganizationForm</param>
        /// <returns>Dal Organization</returns>
        public static D.Organization ToDal(this S.Form.Organizations.OrganizationForm form)
        {
            if (form == null) return null;
            return new D.Organization
            {
                Email = form.Email,
                NameContact = form.NameContact,
                OrName = form.OrName,
                Tel1 = form.Tel1,
                Tel2 = form.Tel2,
                TypeOrganization = form.Organization 
            };
        }
        /// <summary>
        /// Convert ServiceLayer OrganizationUpdate to Dal Organization
        /// </summary>
        /// <param name="form">ServiceLayer OrganizationUpdate</param>
        /// <returns>Dal Organization</returns>
        public static D.Organization ToDal(this S.Form.Organizations.OrganizationUpdate form)
        {
            if (form == null) return null;
            return new D.Organization
            {
                Id = form.Id,
                Email = form.Email,
                NameContact = form.NameContact,
                OrName = form.OrName,
                Tel1 = form.Tel1,
                Tel2 = form.Tel2,
                TypeOrganization = form.Organization
            };
        }
    }
}
