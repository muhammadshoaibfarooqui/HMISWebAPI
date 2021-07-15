using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Repositories
{
    public interface IDepartmentSetupRepos
    {
        Task<IEnumerable<DepartmentSetup>> GetDepartmentSetupAll();
        Task<DepartmentSetup> GetDepartmentSetupByIdAll(string Id);
        Task<DepartmentSetupDTO> GetDepartmentSetupById(string Id);
        Task<DepartmentSetup> InsertDepartmentSetup(DepartmentSetup departmentSetup);
        Task<DepartmentSetup> UpdateDepartmentSetup(DepartmentSetup departmentSetup);
        Task<DepartmentSetup> DeleteDepartmentSetup(string Id);
    }
}
