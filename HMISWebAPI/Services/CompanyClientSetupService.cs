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

        public async Task<CompanyClientSetup> GetCompanyClientSetupByIdAll(string Id)
        {
            var result = await _companyClientSetupRepos.GetCompanyClientSetupByIdAll(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetupDTO> GetCompanyClientSetupById(string Id)
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

        public async Task<CompanyClientSetup> UpdateCompanyClientSetup(string Id,CompanyClientSetup companyClientSetup)
        {
            var c = await _companyClientSetupRepos.GetCompanyClientSetupByIdAll(Id);
            if(Id != null && !String.IsNullOrEmpty(Id))
            {
                c.CmpnyClintCode = companyClientSetup.CmpnyClintCode;
                c.CmpnyClintName = companyClientSetup.CmpnyClintName;
                c.CmpnyAddres = companyClientSetup.CmpnyAddres;
                c.CmpnyAddres1 = companyClientSetup.CmpnyAddres1;
                c.CmpnyAddres2 = companyClientSetup.CmpnyAddres2;
                c.CmpnyContNo = companyClientSetup.CmpnyContNo;
                c.MakerDatetime = DateTime.Now;
                c.MakerId = companyClientSetup.MakerId;
                c.MakerwrkstId = companyClientSetup.MakerwrkstId;
                c.UpdateDatetime = DateTime.Now;
                c.UpdateId = companyClientSetup.UpdateId;
                c.UpdatewrkstId = companyClientSetup.UpdatewrkstId;
                c.OldClientId = companyClientSetup.OldClientId;
                var result = await _companyClientSetupRepos.UpdateCompanyClientSetup(c);
                return result;
            }
            else
            {
                return null;
            }
            
            //var result = await _companyClientSetupRepos.UpdateCompanyClientSetup(companyClientSetup);
            //return result;
            //throw new NotImplementedException();
        }
    }
}
