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

        public async Task<AreaSetupNew> GetAreaSetupNewId(string Id)
        {
            var result = await _hMISManagementContext.areaSetupNews.FirstOrDefaultAsync(a => a.AreaCode == Id);
            return result;
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
            var result = await _hMISManagementContext.areaSetupNews.FirstOrDefaultAsync(a => a.AreaCode == areaSetupNew.AreaCode);
            if(result != null)
            {
                result.AreaCode = areaSetupNew.AreaCode;
                result.Description = areaSetupNew.Description;
                result.CityCode = areaSetupNew.CityCode;
                result.MakerDatetime = DateTime.Now;
                result.MakerId = areaSetupNew.MakerId;
                result.MakerwrkstId = areaSetupNew.MakerwrkstId;
                result.UpdateDatetime = DateTime.Now;
                result.UpdateId = areaSetupNew.UpdateId;
                result.UpdatewrkstId = areaSetupNew.UpdatewrkstId;
                await _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }
    }
}
