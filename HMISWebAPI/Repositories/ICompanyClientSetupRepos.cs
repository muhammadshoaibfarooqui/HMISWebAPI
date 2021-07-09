using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public interface ICompanyClientSetupRepos
    {
        Task<IEnumerable<CompanyClientSetup>> GetCompanyClientSetupAll();
        Task<CompanyClientSetup> GetCompanyClientSetupById(string Id);
        Task<CompanyClientSetup> InsertCompanyClientSetup(CompanyClientSetup companyClientSetup);
        Task<CompanyClientSetup> UpdateCompanyClientSetup(CompanyClientSetup companyClientSetup);
        Task<CompanyClientSetup> DeleteCompanyClientSetup(string Id);
    }
}
