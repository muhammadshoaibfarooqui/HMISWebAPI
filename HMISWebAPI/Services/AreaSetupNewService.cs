using HMISWebAPI.Repositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public class AreaSetupNewService : IAreaSetupNew
    {
        private readonly IAreaSetupNewRepos _areaSetupNewRepos;
        public AreaSetupNewService(IAreaSetupNewRepos areaSetupNewRepos)
        {
            _areaSetupNewRepos = areaSetupNewRepos;
        }
        public async Task<AreaSetupNew> DeleteAreaSetupNew(string Id)
        {
            var result = await _areaSetupNewRepos.DeleteAreaSetupNew(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<AreaSetupNew>> GetAreaSetupNewAll()
        {
            var result = await _areaSetupNewRepos.GetAreaSetupNewAll();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNew> GetAreaSetupNewId(string Id)
        {
            var result = await _areaSetupNewRepos.GetAreaSetupNewId(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNew> InsertAreaSetupNew(AreaSetupNew areaSetupNew)
        {
            var result = await _areaSetupNewRepos.InsertAreaSetupNew(areaSetupNew);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<AreaSetupNew> UpdateAreaSetupNew(AreaSetupNew areaSetupNew)
        {
            var result = await _areaSetupNewRepos.UpdateAreaSetupNew(areaSetupNew);
            return result;
            //throw new NotImplementedException();
        }
    }
}
