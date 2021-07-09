using HMISWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMISWebAPI.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DepartmentSetupController : ControllerBase
    {
        private readonly IDepartmentSetup _departmentSetup;
        public DepartmentSetupController(IDepartmentSetup departmentSetup)
        {
            _departmentSetup = departmentSetup;
        }

        [HttpGet]
        [Route("GetDepartmentSetupAll")]
        public async Task<ActionResult> GetDepartmentSetupAll()
        {
            try
            {
                //return Ok(await _employeeRepository.GetEmployees());
                return Ok(await _departmentSetup.GetDepartmentSetupAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetDepartmentSetupById")]
        public async Task<ActionResult<DepartmentSetup>> GetDepartmentSetupById(string Id)
        {
            try
            {
                var result = await _departmentSetup.GetDepartmentSetupById(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpPost]
        [Route("InsertDepartmentSetup")]
        public async Task<ActionResult<DepartmentSetup>> InsertDepartmentSetup(DepartmentSetup departmentSetup)
        {
            try
            {
                if (departmentSetup == null)
                {
                    return BadRequest();
                }
                var insertEmployee = await _departmentSetup.InsertDepartmentSetup(departmentSetup);
                return CreatedAtAction(nameof(GetDepartmentSetupAll), new { Id = insertEmployee.MakerId }, insertEmployee);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpPut]
        [Route("UpdateDepartmentSetup")]
        public async Task<ActionResult<DepartmentSetup>> UpdateDepartmentSetup(string Id, DepartmentSetup departmentSetup)
        {
            try
            {
                if (Id != departmentSetup.DptCode)
                {
                    return BadRequest("Id Mismatched");
                }
                var updateEmployee = await _departmentSetup.GetDepartmentSetupById(Id);
                if (updateEmployee == null)
                {
                    return NotFound($"DepartmentSetup departmentSetup.Id ={Id} Not Found");
                }
                var employeeUpdate = await _departmentSetup.UpdateDepartmentSetup(departmentSetup);
                return employeeUpdate;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpDelete]
        [Route("DeleteDepartmentSetup")]
        public async Task<ActionResult<DepartmentSetup>> DeleteDepartmentSetup(string Id)
        {
            var employeeDelete = await _departmentSetup.DeleteDepartmentSetup(Id);
            if (employeeDelete == null)
            {
                return NotFound($"Employee Id = {Id} Not Found");
            }
            return await _departmentSetup.DeleteDepartmentSetup(Id);
        }
    }
}
