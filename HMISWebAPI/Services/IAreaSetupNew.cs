using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public interface IAreaSetupNew
    {
        Task<IEnumerable<AreaSetupNew>> GetAreaSetupNewAll();
        Task<AreaSetupNew> GetAreaSetupNewId(string Id);
        Task<AreaSetupNew> InsertAreaSetupNew(AreaSetupNew areaSetupNew);
        Task<AreaSetupNew> UpdateAreaSetupNew(AreaSetupNew areaSetupNew);
        Task<AreaSetupNew> DeleteAreaSetupNew(string Id);
    }
}
