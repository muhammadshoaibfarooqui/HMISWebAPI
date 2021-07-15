using HMISWebAPI.Repositories;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Services
{
    public class DepartmentSetupService : IDepartmentSetup
    {
        private readonly IDepartmentSetupRepos _departmentSetupRepos;
        public DepartmentSetupService(IDepartmentSetupRepos departmentSetupRepos)
        {
            _departmentSetupRepos = departmentSetupRepos;
        }
        public async Task<DepartmentSetup> DeleteDepartmentSetup(string Id)
        {
            var result = await _departmentSetupRepos.DeleteDepartmentSetup(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<DepartmentSetup>> GetDepartmentSetupAll()
        {
            var result = await _departmentSetupRepos.GetDepartmentSetupAll();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetup> GetDepartmentSetupByIdAll(string Id)
        {
            var result = await _departmentSetupRepos.GetDepartmentSetupByIdAll(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetupDTO> GetDepartmentSetupById(string Id)
        {
            var result = await _departmentSetupRepos.GetDepartmentSetupById(Id);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetup> InsertDepartmentSetup(DepartmentSetup departmentSetup)
        {
            var result = await _departmentSetupRepos.InsertDepartmentSetup(departmentSetup);
            return result;
            //throw new NotImplementedException();
        }

        public async Task<DepartmentSetup> UpdateDepartmentSetup(string Id,DepartmentSetup departmentSetup)
        {
            var c = await _departmentSetupRepos.GetDepartmentSetupByIdAll(Id);
            if(Id != null)
            {
                c.DptCode = departmentSetup.DptCode;
                c.DptDescription = departmentSetup.DptDescription;
                c.DptStatus = departmentSetup.DptStatus;
                c.MakerDatetime = DateTime.Now;
                c.MakerId = departmentSetup.MakerId;
                c.MakerwrkstId = departmentSetup.MakerwrkstId;
                c.UpdateDatetime = DateTime.Now;
                c.UpdateId = departmentSetup.UpdateId;
                c.UpdatewrkstId = departmentSetup.UpdatewrkstId;
                c.EbsDptCode = departmentSetup.EbsDptCode;
                var result = await _departmentSetupRepos.UpdateDepartmentSetup(c);
                return result;
            }
            else
            {
                return null;
            }
            //var result = await _departmentSetupRepos.UpdateDepartmentSetup(departmentSetup);
            //return result;
            //throw new NotImplementedException();
        }
    }
}
