using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public interface ICompanyClientSetup
    {
        Task<IEnumerable<CompanyClientSetup>> GetCompanyClientSetupAll();
        Task<CompanyClientSetup> GetCompanyClientSetupByIdAll(string Id);
        Task<CompanyClientSetupDTO> GetCompanyClientSetupById(string Id);
        Task<CompanyClientSetup> InsertCompanyClientSetup(CompanyClientSetup companyClientSetup);
        //Task<CompanyClientSetup> UpdateCompanyClientSetup(CompanyClientSetup companyClientSetup);
        Task<CompanyClientSetup> UpdateCompanyClientSetup(string Id,CompanyClientSetup companyClientSetup);
        Task<CompanyClientSetup> DeleteCompanyClientSetup(string Id);
    }
}
