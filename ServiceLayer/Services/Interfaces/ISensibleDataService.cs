
using ServiceLayer.Models;
using ServiceLayer.Models.Form.SensibleData;
using ServiceLayer.Models.Views;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISensibleDataService : IService<SensibleDataForm, VSensibleDataByOrganization, int>
    {
        /// <summary>
        /// Function to get one sensible data
        /// </summary>
        /// <param name="Id">id of sensible data</param>
        /// <returns>SensibleData</returns>
        SensibleData GetSensibleData(int Id);

        /// <summary>
        /// Funtion to update a SensibleData
        /// </summary>
        /// <param name="form">SensibleData</param>
        /// <returns>VSensibleDataByOrganization</returns>
        VSensibleDataByOrganization Update(SensibleData form);
        SensibleData UpdateSensibleData(SensibleData form);
    }
}
