using HMISWebAPI.Repositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public class CitySetupService : ICitySetup
    {
        private readonly ICitySetupRepos _citySetupRepos;
        public CitySetupService(ICitySetupRepos citySetupRepos)
        {
            _citySetupRepos = citySetupRepos;
        }
        public async Task<CitySetup> DeleteCitySetup(string Id)
        {
            var result = await _citySetupRepos.DeleteCitySetup(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CitySetup>> GetCitySetupAll()
        {
            var result = await _citySetupRepos.GetCitySetupAll();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CitySetup> GetCitySetupById(string Id)
        {
            var result = await _citySetupRepos.GetCitySetupById(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CitySetup> InsertCitySetup(CitySetup citySetup)
        {
            var result = await _citySetupRepos.InsertCitySetup(citySetup);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CitySetup> UpdateCitySetup(CitySetup citySetup)
        {
            var result = await _citySetupRepos.UpdateCitySetup(citySetup);
            return result;
            //throw new NotImplementedException();
        }
    }
}
