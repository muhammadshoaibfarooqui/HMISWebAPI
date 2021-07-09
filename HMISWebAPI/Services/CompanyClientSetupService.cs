using HMISWebAPI.Repositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public class CompanyClientSetupService : ICompanyClientSetup
    {
        private readonly ICompanyClientSetupRepos _companyClientSetupRepos;
        public CompanyClientSetupService(ICompanyClientSetupRepos companyClientSetupRepos)
        {
            _companyClientSetupRepos = companyClientSetupRepos;
        }
        public async Task<CompanyClientSetup> DeleteCompanyClientSetup(string Id)
        {
            var result = await _companyClientSetupRepos.DeleteCompanyClientSetup(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanyClientSetup>> GetCompanyClientSetupAll()
        {
            var result = await _companyClientSetupRepos.GetCompanyClientSetupAll();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetup> GetCompanyClientSetupById(string Id)
        {
            var result = await _companyClientSetupRepos.GetCompanyClientSetupById(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetup> InsertCompanyClientSetup(CompanyClientSetup companyClientSetup)
        {
            var result = await _companyClientSetupRepos.InsertCompanyClientSetup(companyClientSetup);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetup> UpdateCompanyClientSetup(CompanyClientSetup companyClientSetup)
        {
            var result = await _companyClientSetupRepos.UpdateCompanyClientSetup(companyClientSetup);
            return result;
            //throw new NotImplementedException();
        }
    }
}
