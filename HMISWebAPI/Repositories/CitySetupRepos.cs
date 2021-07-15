using HMISWebAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public class CitySetupRepos : ICitySetupRepos
    {
        private readonly HMISManagementContext _hMISManagementContext;
        public CitySetupRepos(HMISManagementContext hMISManagementContext)
        {
            _hMISManagementContext = hMISManagementContext;
        }
        public async Task<CitySetup> DeleteCitySetup(string Id)
        {
            var result = await _hMISManagementContext.citySetups.Where(a => a.CityCode == Id).FirstOrDefaultAsync();
            if(result != null)
            {
                _hMISManagementContext.citySetups.Remove(result);
                await _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CitySetup>> GetCitySetupAll()
        {
            var result = await _hMISManagementContext.citySetups.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CitySetup> GetCitySetupByIdAll(string Id)
        {
            var result = await _hMISManagementContext.citySetups.FirstOrDefaultAsync(a => a.CityCode == Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CitySetupDTO> GetCitySetupById(string Id)
        {
            var c = new CitySetupDTO();
            var result = await _hMISManagementContext.citySetups.FirstOrDefaultAsync(a => a.CityCode == Id);
            if(result != null || !String.IsNullOrEmpty(Id))
            {
                c.CityCode = result.CityCode;
                c.CityDescription = result.CityDescription;
                c.Status = result.Status;
            }
            return c;
            //throw new NotImplementedException();
        }

        public async Task<CitySetup> InsertCitySetup(CitySetup citySetup)
        {
            var result = await _hMISManagementContext.citySetups.AddAsync(citySetup);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }

        public async Task<CitySetup> UpdateCitySetup(CitySetup citySetup)
        {
            var result = _hMISManagementContext.citySetups.Update(citySetup);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //var result = await _hMISManagementContext.citySetups.FirstOrDefaultAsync(a => a.CityCode == citySetup.CityCode);
            //if(result != null)
            //{
            //    result.CityCode = citySetup.CityCode;
            //    result.CityDescription = citySetup.CityDescription;
            //    result.MakerDatetime = DateTime.Now;
            //    result.MakerId = citySetup.MakerId;
            //    result.MakerwrkstId = citySetup.MakerwrkstId;
            //    result.UpdateDatetime = citySetup.UpdateDatetime;
            //    result.UpdateId = citySetup.UpdateId;
            //    result.UpdatewrkstId = citySetup.UpdatewrkstId;
            //    result.Status = citySetup.Status;
            //    await _hMISManagementContext.SaveChangesAsync();
            //    return result;
            //}
            //return null;
            //throw new NotImplementedException();
        }
    }
}
