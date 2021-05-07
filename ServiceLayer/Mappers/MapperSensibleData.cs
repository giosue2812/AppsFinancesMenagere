using S = ServiceLayer.Models;
using D = DAL.Models;

namespace ServiceLayer.Mappers
{
    public static class MapperSensibleData
    {
        /// <summary>
        /// Convert a Dal VSensibleDataByOrganization to ServiceLayer VSensibleDataByOrganization
        /// </summary>
        /// <param name="entity">Dal VSensibleDataByOrganization</param>
        /// <returns>ServiceLayer VSensibleDataByOrganization</returns>
        public static S.Views.VSensibleDataByOrganization ToServiceLayer(this D.Views.VSensibleDataByOrganization entity)
        {
            if (entity == null) return null;
            return new S.Views.VSensibleDataByOrganization
            {
                Id = entity.Id,
                AddCountry = entity.AddCountry,
                AddNumber = entity.AddNumber,
                AddPostalCode = entity.AddPostalCode,
                AddStreet = entity.AddStreet,
                IdOrganization = entity.IdOrganization
            };
        }
        /// <summary>
        /// Convert a ServiceLayer SensibleDataForm to Dal SensibleData
        /// </summary>
        /// <param name="form">ServiceLayer SensibleDataForm</param>
        /// <returns>Dal SensibleData</returns>
        public static D.SensibleData ToDal(this S.Form.SensibleData.SensibleDataForm form)
        {
            if (form == null) return null;
            return new D.SensibleData
            {
                AddCountry = form.AddCountry,
                AddNumber = form.AddNumber,
                AddPostalCode = form.AddPostalCode,
                AddStreet = form.AddStreet
            };
        }
        /// <summary>
        /// Convert a ServiceLayer SensibleData to Dal SensibleData
        /// </summary>
        /// <param name="form">ServiceLayer SensibleData</param>
        /// <returns>Dal SensibleData</returns>
        public static D.SensibleData ToDal(this S.SensibleData form)
        {
            if (form == null) return null;
            return new D.SensibleData
            {
                Id = form.Id,
                AddCountry = form.AddCountry,
                AddNumber = form.AddNumber,
                AddPostalCode = form.AddPostalCode,
                AddStreet = form.AddStreet
            };
        }
    }
}
