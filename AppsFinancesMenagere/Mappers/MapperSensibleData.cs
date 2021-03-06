using A = AppsFinancesMenagere.Models;
using S = ServiceLayer.Models;

namespace AppsFinancesMenagere.Mappers
{
    public static class MapperSensibleData
    {
        public static A.SensibleDataGetByOrganization ToApi(this S.Views.VSensibleDataByOrganization entity)
        {
            if (entity == null) return null;
            return new A.SensibleDataGetByOrganization
            {
                Id = entity.Id,
                AddCountry = entity.AddCountry,
                AddNumber = entity.AddNumber,
                AddPostalCode = entity.AddPostalCode,
                AddStreet = entity.AddStreet,
                IdOrganization = entity.IdOrganization,
                AddCity = entity.AddCity,
                OrName = entity.OrName
            };
        }
        public static S.Form.SensibleData.SensibleDataForm ToServiceLayer(this A.Form.SensibleData.SensibleDataForm form)
        {
            if (form == null) return null;
            return new S.Form.SensibleData.SensibleDataForm
            {
                AddCountry = form.AddCountry,
                AddNumber = form.AddNumber,
                AddPostalCode = form.AddPostalCode,
                AddStreet = form.AddStreet,
                AddCity = form.AddCity
            };
        }
        public static S.SensibleData ToServiceLayer(this A.Form.SensibleData.SensibleDataUpdate form)
        {
            if (form == null) return null;
            return new S.SensibleData
            {
                Id = form.Id,
                AddCountry = form.AddCountry,
                AddNumber = form.AddNumber,
                AddPostalCode = form.AddPostalCode,
                AddStreet = form.AddStreet,
                AddCity = form.AddCity
            };
        }
        public static A.SensibleData ToApiSensibleData(this S.SensibleData entity)
        {
            if (entity == null) return null;
            return new A.SensibleData
            {
                Id = entity.Id,
                AddCountry = entity.AddCountry,
                AddNumber = entity.AddNumber,
                AddPostalCode = entity.AddPostalCode,
                AddStreet = entity.AddStreet,
                AddCity = entity.AddCity
            };
        }
    }
}
