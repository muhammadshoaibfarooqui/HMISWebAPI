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

        public async Task<DepartmentSetup> GetDepartmentSetupById(string Id)
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

        public async Task<DepartmentSetup> UpdateDepartmentSetup(DepartmentSetup departmentSetup)
        {
            var result = await _departmentSetupRepos.UpdateDepartmentSetup(departmentSetup);
            return result;
            //throw new NotImplementedException();
        }
    }
}
