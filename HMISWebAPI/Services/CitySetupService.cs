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

        public async Task<CitySetup> GetCitySetupByIdAll(string Id)
        {
            var result = await _citySetupRepos.GetCitySetupByIdAll(Id);
            return result;
            //throw new NotImplementedException();
        }
        public async Task<CitySetupDTO> GetCitySetupById(string Id)
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

        public async Task<CitySetup> UpdateCitySetup(string Id,CitySetup citySetup)
        {
            var c = await _citySetupRepos.GetCitySetupByIdAll(Id);
            if (Id != null && !String.IsNullOrEmpty(Id))
            {
                c.CityCode = citySetup.CityCode;
                c.CityDescription = citySetup.CityDescription;
                c.MakerDatetime = DateTime.Now; //citySetup.MakerDatetime;
                c.MakerId = citySetup.MakerId;
                c.MakerwrkstId = citySetup.MakerwrkstId;
                c.UpdateDatetime = DateTime.Now; //citySetup.UpdateDatetime;
                c.UpdateId = citySetup.UpdateId;
                c.UpdatewrkstId = citySetup.UpdatewrkstId;
                c.Status = citySetup.Status;
                var result = await _citySetupRepos.UpdateCitySetup(c);
                return result;
            }
            else
            {
                return null;
            }
            //var result = await _citySetupRepos.UpdateCitySetup(citySetup);
            //return result;
            //throw new NotImplementedException();
        }
    }
}
