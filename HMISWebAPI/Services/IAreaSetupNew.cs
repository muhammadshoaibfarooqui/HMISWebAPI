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
        Task<AreaSetupNewVM> GetAreaSetupNewId(string Id);

        Task<AreaSetupNew> GetAreaSetupNewByIdAll(string Id);
        Task<AreaSetupNew> InsertAreaSetupNew(AreaSetupNew areaSetupNew);
        //Task<AreaSetupNew> UpdateAreaSetupNew(AreaSetupNew areaSetupNew);

        Task<AreaSetupNew> UpdateAreaSetupNew(string Id, AreaSetupNewDTO areaSetupNewDTO);
        Task<AreaSetupNew> DeleteAreaSetupNew(string Id);
    }
}
