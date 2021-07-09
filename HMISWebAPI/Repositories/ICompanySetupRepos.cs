using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public interface ICompanySetupRepos
    {
        Task<IEnumerable<CompanySetup>> GetCompanySetupAll();
        Task<CompanySetup> GetCompanySetupById(string Id);
        Task<CompanySetup> InsertCompanySetup(CompanySetup companySetup);
        Task<CompanySetup> UpdateCompanySetup(CompanySetup companySetup);
        Task<CompanySetup> DeleteCompanySetup(string Id);
    }
}
