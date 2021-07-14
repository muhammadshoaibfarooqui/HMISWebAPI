using HMISWebAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public class AreaSetupNewRepos : IAreaSetupNewRepos
    {
        private readonly HMISManagementContext _hMISManagementContext;
        public AreaSetupNewRepos(HMISManagementContext hMISManagementContext)
        {
            _hMISManagementContext = hMISManagementContext;
        }
        public async Task<AreaSetupNew> DeleteAreaSetupNew(string Id)
        {
            var result = await _hMISManagementContext.areaSetupNews.Where(a => a.AreaCode == Id).FirstOrDefaultAsync();
            if(result != null)
            {
                _hMISManagementContext.areaSetupNews.Remove(result);
                await _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return result;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<AreaSetupNew>> GetAreaSetupNewAll()
        {
            var result = await _hMISManagementContext.areaSetupNews.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNew> GetAreaSetupNewByIdAll(string Id)
        {
            //var c = new AreaSetupNew();
            var result = await _hMISManagementContext.areaSetupNews.FirstOrDefaultAsync(a => a.AreaCode == Id);
            //string citycode = result.CityCode;
            //var result2 = await _hMISManagementContext.citySetups.FirstOrDefaultAsync(a => a.CityCode == citycode);
            //if (result != null || result2 != null)
            //{
            //    c.AreaCode = Id;
            //    c.CityCode = result2.CityDescription;
            //    c.Description = result.Description;

            //    return c;
            //}
            return result;
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNewVM> GetAreaSetupNewId(string Id)
        {
            //var c = new AreaSetupNew();
            var a = new AreaSetupNewVM();
            var result = await _hMISManagementContext.areaSetupNews.FirstOrDefaultAsync(b => b.AreaCode == Id);
            string citycode = result.CityCode;

            //------------Linq Query Join Lamba Expression-----------
            //var result = _hMISManagementContext.areaSetupNews.Where(b => b.AreaCode == Id).Join(_hMISManagementContext.citySetups, r => r.CityCode, p => p.CityCode, (r, p) => new { r.CityCode, r.Description, p.CityDescription });
            
            
            var result2 = await _hMISManagementContext.citySetups.FirstOrDefaultAsync(b => b.CityCode == citycode);
            if (result != null ) //result2 != null)
            {
                a.AreaCode = Id;
                a.Description = result.Description;
                a.CityName = result2.CityDescription;
                //a.CityCode = result.FirstOrDefault()?.CityCode;
                //a.Description = result.FirstOrDefault()?.Description;
                //a.CityName = result2.FirstOrDefault()?.CityDescription;

                //return a;
            }
            return a;
            
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNew> InsertAreaSetupNew(AreaSetupNew areaSetupNew)
        {
            var result = await _hMISManagementContext.areaSetupNews.AddAsync(areaSetupNew);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNew> UpdateAreaSetupNew(AreaSetupNew areaSetupNew)
        {
            //var result = await _hMISManagementContext.areaSetupNews.FirstOrDefaultAsync(a => a.AreaCode == areaSetupNew.AreaCode);
            //if(result != null)
            //{
            //    result.AreaCode = areaSetupNew.AreaCode;
            //    result.Description = areaSetupNew.Description;
            //    result.CityCode = areaSetupNew.CityCode;
            //    result.MakerDatetime = DateTime.Now;
            //    result.MakerId = areaSetupNew.MakerId;
            //    result.MakerwrkstId = areaSetupNew.MakerwrkstId;
            //    result.UpdateDatetime = DateTime.Now;
            //    result.UpdateId = areaSetupNew.UpdateId;
            //    result.UpdatewrkstId = areaSetupNew.UpdatewrkstId;
            //    await _hMISManagementContext.SaveChangesAsync();
            //    return result;
            //}
            //return null;

            var result =  _hMISManagementContext.areaSetupNews.Update(areaSetupNew);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }
    }
}
