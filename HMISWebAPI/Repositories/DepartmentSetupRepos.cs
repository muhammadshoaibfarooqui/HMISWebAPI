using HMISWebAPI.DataContext;
using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public class DepartmentSetupRepos : IDepartmentSetupRepos
    {
        private readonly HMISManagementContext _hMISManagementContext;
        public DepartmentSetupRepos(HMISManagementContext hMISManagementContext)
        {
            _hMISManagementContext = hMISManagementContext;
        }
        public async Task<DepartmentSetup> DeleteDepartmentSetup(string Id)
        {
            var result = await _hMISManagementContext.departmentSetups.Where(a => a.DptCode == Id).FirstOrDefaultAsync();
            if (result != null)
            {
                _hMISManagementContext.departmentSetups.Remove(result);
                await _hMISManagementContext.SaveChangesAsync();
                return result;
            }
            return null;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<DepartmentSetup>> GetDepartmentSetupAll()
        {
            return await _hMISManagementContext.departmentSetups.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetup> GetDepartmentSetupByIdAll(string Id)
        {
            return await _hMISManagementContext.departmentSetups.FirstOrDefaultAsync(a => a.DptCode == Id);
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetupDTO> GetDepartmentSetupById(string Id)
        {
            var c = new DepartmentSetupDTO();
            var result = await _hMISManagementContext.departmentSetups.FirstOrDefaultAsync(a => a.DptCode == Id);
            if(result != null || String.IsNullOrEmpty(Id))
            {
                c.DptCode = result.DptCode;
                c.DptDescription = result.DptDescription;
                c.DptStatus = result.DptStatus;
            }
            else
            {
                return null;
            }
            return c;
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetup> InsertDepartmentSetup(DepartmentSetup departmentSetup)
        {
            var result = await _hMISManagementContext.departmentSetups.AddAsync(departmentSetup);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetup> UpdateDepartmentSetup(DepartmentSetup departmentSetup)
        {
            var result = _hMISManagementContext.departmentSetups.Update(departmentSetup);
            await _hMISManagementContext.SaveChangesAsync();
            return result.Entity;
            //var result = await _hMISManagementContext.departmentSetups.FirstOrDefaultAsync(a => a.DptCode == departmentSetup.DptCode);
            //if (result != null)
            //{
            //    result.DptCode = departmentSetup.DptCode;
            //    result.DptDescription = departmentSetup.DptDescription;
            //    result.DptStatus = departmentSetup.DptStatus;

            //    result.MakerDatetime = DateTime.Now;
            //    result.MakerId = departmentSetup.MakerId;
            //    result.MakerwrkstId = departmentSetup.MakerwrkstId;

            //    result.UpdateDatetime = DateTime.Now;
            //    result.UpdateId = departmentSetup.UpdateId;
            //    result.UpdatewrkstId = departmentSetup.UpdatewrkstId;

            //    result.EbsDptCode = departmentSetup.EbsDptCode;
                
            //    await _hMISManagementContext.SaveChangesAsync();
            //    return result;
            //}
            //return null;
            //throw new NotImplementedException();
        }
    }
}
