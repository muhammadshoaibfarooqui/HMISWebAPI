using HMISWebAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public class CompanyClientSetupRepos : ICompanyClientSetupRepos
    {
        private readonly HMISManagementContext _hMISManagementContext;
        public CompanyClientSetupRepos(HMISManagementContext hMISManagementContext)
        {
            _hMISManagementContext = hMISManagementContext;
        }
        public async Task<CompanyClientSetup> DeleteCompanyClientSetup(string Id)
        {
            var result = await _hMISManagementContext.companyClientSetups.Where(a => a.CmpnyClintCode == Id).FirstOrDefaultAsync();
            if (result != null)
            {
                _hMISManagementContext.companyClientSetups.Remove(result);
                _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanyClientSetup>> GetCompanyClientSetupAll()
        {
            var result = await _hMISManagementContext.companyClientSetups.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetup> GetCompanyClientSetupByIdAll(string Id)
        {
            var result = await _hMISManagementContext.companyClientSetups.FirstOrDefaultAsync(a => a.CmpnyClintCode == Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetupDTO> GetCompanyClientSetupById(string Id)
        {
            var c = new CompanyClientSetupDTO();
            var result = await _hMISManagementContext.companyClientSetups.FirstOrDefaultAsync(a => a.CmpnyClintCode == Id);
            if(result != null)
            {
                c.CmpnyClintCode = result.CmpnyClintCode;
                c.CmpnyClintName = result.CmpnyClintName;
                c.CmpnyAddres = result.CmpnyAddres;
                c.CmpnyContNo = result.CmpnyContNo;
            }
            else
            {
                return null;
            }
            return c;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetup> InsertCompanyClientSetup(CompanyClientSetup companyClientSetup)
        {
            var result = await _hMISManagementContext.companyClientSetups.AddAsync(companyClientSetup);
            _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }

        public async Task<CompanyClientSetup> UpdateCompanyClientSetup(CompanyClientSetup companyClientSetup)
        {
            var result = _hMISManagementContext.companyClientSetups.Update(companyClientSetup);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //var result = await _hMISManagementContext.companyClientSetups.FirstOrDefaultAsync(a => a.CmpnyClintCode == companyClientSetup.CmpnyClintCode);
            //if (result != null)
            //{
            //    result.CmpnyClintCode = companyClientSetup.CmpnyClintCode;
            //    result.CmpnyClintName = companyClientSetup.CmpnyClintName;
            //    result.CmpnyAddres = companyClientSetup.CmpnyAddres;
            //    result.CmpnyAddres1 = companyClientSetup.CmpnyAddres1;
            //    result.CmpnyAddres2 = companyClientSetup.CmpnyAddres2;
            //    result.CmpnyContNo = companyClientSetup.CmpnyContNo;
            //    result.MakerDatetime = DateTime.Now;
            //    result.MakerId = companyClientSetup.MakerId;
            //    result.MakerwrkstId = companyClientSetup.MakerwrkstId;

            //    result.UpdateDatetime = DateTime.Now;
            //    result.UpdateId = companyClientSetup.UpdateId;
            //    result.UpdatewrkstId = companyClientSetup.UpdatewrkstId;
            //    result.OldClientId = companyClientSetup.OldClientId;

            //    await _hMISManagementContext.SaveChangesAsync();
            //    return result;
            //}
            //return null;
            //throw new NotImplementedException();
        }
    }
}
