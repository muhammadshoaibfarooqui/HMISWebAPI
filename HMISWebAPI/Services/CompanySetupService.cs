using HMISWebAPI.Repositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public class CompanySetupService : ICompanySetup
    {
        private readonly ICompanySetupRepos _companySetupRepos;
        public CompanySetupService(ICompanySetupRepos companySetupRepos)
        {
            _companySetupRepos = companySetupRepos;
        }
        public async Task<CompanySetup> DeleteCompanySetup(string Id)
        {
            var result = await _companySetupRepos.DeleteCompanySetup(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanySetup>> GetCompanySetupAll()
        {
            var result = await _companySetupRepos.GetCompanySetupAll();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanySetup> GetCompanySetupById(string Id)
        {
            var result = await _companySetupRepos.GetCompanySetupById(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanySetup> InsertCompanySetup(CompanySetup companySetup)
        {
            var result = await _companySetupRepos.InsertCompanySetup(companySetup);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanySetup> UpdateCompanySetup(string Id,CompanySetupDTO companySetupDTO)
        {
            var c = await _companySetupRepos.GetCompanySetupById(Id);
            c.CmpnyAddres= companySetupDTO.CmpnyAddres;
            c.CmpnyCode = Id;
            var result = await _companySetupRepos.UpdateCompanySetup(c);
            return result;
            //throw new NotImplementedException();
        }
    }
}
