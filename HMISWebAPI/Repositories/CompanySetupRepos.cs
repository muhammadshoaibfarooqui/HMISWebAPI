using HMISWebAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public class CompanySetupRepos : ICompanySetupRepos
    {
        private readonly HMISManagementContext _hMISManagementContext;
        public CompanySetupRepos(HMISManagementContext hMISManagementContext)
        {
            _hMISManagementContext = hMISManagementContext;
        }
        public async Task<CompanySetup> DeleteCompanySetup(string Id)
        {
            var result = await _hMISManagementContext.companySetups.Where(a => a.CmpnyCode == Id).FirstOrDefaultAsync();
            if(result != null)
            {
                _hMISManagementContext.companySetups.Remove(result);
                _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<CompanySetup>> GetCompanySetupAll()
        {
            var result = await _hMISManagementContext.companySetups.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanySetup> GetCompanySetupById(string Id)
        {
            var result = await _hMISManagementContext.companySetups.FirstOrDefaultAsync(a => a.CmpnyCode == Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<CompanySetup> InsertCompanySetup(CompanySetup companySetup)
        {
            var result = await _hMISManagementContext.companySetups.AddAsync(companySetup);
            _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }

        public async Task<CompanySetup> UpdateCompanySetup(CompanySetup companySetup)
        {
            var result = await _hMISManagementContext.companySetups.FirstOrDefaultAsync(a => a.CmpnyCode == companySetup.CmpnyCode);
            if(result != null)
            {
                result.CmpnyCode = companySetup.CmpnyCode;
                result.CmpnyName = companySetup.CmpnyName;
                result.CmpnySlogin = companySetup.CmpnySlogin;
                result.CmpnyLogo = companySetup.CmpnyLogo;
                result.CmpnyAddres = companySetup.CmpnyAddres;
                result.CmpnyAddres1 = companySetup.CmpnyAddres1;
                result.CmpnyAddres2 = companySetup.CmpnyAddres2;
                result.CmpnyUanNo = companySetup.CmpnyUanNo;
                result.CmpnyLandLine = companySetup.CmpnyLandLine;

                result.CmpnyFaxNo = companySetup.CmpnyFaxNo;
                result.CmpnyEmail = companySetup.CmpnyEmail;
                result.CmpnyUrl = companySetup.CmpnyUrl;
                result.CmpnyFlag = companySetup.CmpnyFlag;
                result.CmpnyContPerson = companySetup.CmpnyContPerson;

                result.CmpnyContDesig = companySetup.CmpnyContDesig;
                result.CmpnyContNo = companySetup.CmpnyContNo;
                result.MakerDatetime = DateTime.Now;
                result.MakerId = companySetup.MakerId;
                result.MakerwrkstId = companySetup.MakerwrkstId;

                result.UpdateDatetime = DateTime.Now;
                result.UpdateId = companySetup.UpdateId;
                result.UpdatewrkstId = companySetup.UpdatewrkstId;
                result.CmpnyZakat = companySetup.CmpnyZakat;
                result.CmpnyDiscount = companySetup.CmpnyDiscount;

                result.CmpnyGlCode = companySetup.CmpnyGlCode;
                result.CmpnyOldCId = companySetup.CmpnyOldCId;
                result.CmpnyStatus = companySetup.CmpnyStatus;
                result.CmpnyPkgRateRef = companySetup.CmpnyPkgRateRef;

                result.CmpnyEbsAccNo = companySetup.CmpnyEbsAccNo;
                await _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }
    }
}
