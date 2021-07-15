using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public interface ICitySetup
    {
        Task<IEnumerable<CitySetup>> GetCitySetupAll();
        Task<CitySetup> GetCitySetupByIdAll(string Id);
        Task<CitySetupDTO> GetCitySetupById(string Id);
        Task<CitySetup> InsertCitySetup(CitySetup citySetup);
        //Task<CitySetup> UpdateCitySetup(CitySetup citySetup);
        Task<CitySetup> UpdateCitySetup(string Id,CitySetup citySetup);
        Task<CitySetup> DeleteCitySetup(string Id);
    }
}
