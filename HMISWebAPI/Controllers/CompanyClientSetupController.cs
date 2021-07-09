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
    public class CompanyClientSetupController : ControllerBase
    {
        private readonly ICompanyClientSetup _companyClientSetup;
        public CompanyClientSetupController(ICompanyClientSetup companyClientSetup)
        {
            _companyClientSetup = companyClientSetup;
        }

        [HttpGet]
        [Route("GetCompanyClientSetupAll")]
        public async Task<ActionResult> GetCompanyClientSetupAll()
        {
            try
            {
                //return Ok(await _employeeRepository.GetEmployees());
                return Ok(await _companyClientSetup.GetCompanyClientSetupAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetCompanyClientSetupById")]
        public async Task<ActionResult<CompanyClientSetup>> GetCompanyClientSetupById(string Id)
        {
            try
            {
                var result = await _companyClientSetup.GetCompanyClientSetupById(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpPost]
        [Route("InsertCompanyClientSetup")]
        public async Task<ActionResult<CompanyClientSetup>> InsertCompanyClientSetup(CompanyClientSetup companyClientSetup)
        {
            try
            {
                if (companyClientSetup == null)
                {
                    return BadRequest();
                }
                var insertCompanyClientSetup = await _companyClientSetup.InsertCompanyClientSetup(companyClientSetup);
                return CreatedAtAction(nameof(GetCompanyClientSetupAll), new { Id = insertCompanyClientSetup.CmpnyClintCode }, insertCompanyClientSetup);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");

            }
        }

        [HttpPut]
        [Route("UpdateCompanyClientSetup")]
        public async Task<ActionResult<CompanyClientSetup>> UpdateCompanyClientSetup(string Id, CompanyClientSetup companyClientSetup)
        {
            try
            {
                if (Id != companyClientSetup.CmpnyClintCode)
                {
                    return BadRequest("Id Mismatched");
                }
                var updateCompanyClientSetup = await _companyClientSetup.GetCompanyClientSetupById(Id);
                if (updateCompanyClientSetup == null)
                {
                    return NotFound($"CompanyClientSetup companyClientSetup.CmpnyClintCode ={Id} Not Found");
                }
                var comapnyClientSetupUpdate = await _companyClientSetup.UpdateCompanyClientSetup(companyClientSetup);
                return comapnyClientSetupUpdate;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpDelete]
        [Route("DeleteCompanyClientSetup")]
        public async Task<ActionResult<CompanyClientSetup>> DeleteCompanyClientSetup(string Id)
        {
            var companyClientSetupDelete = await _companyClientSetup.DeleteCompanyClientSetup(Id);
            if (companyClientSetupDelete == null)
            {
                return NotFound($"CompanyClientSetup CmpnyClintCode = {Id} Not Found");
            }
            return await _companyClientSetup.DeleteCompanyClientSetup(Id);
        }
    }
}
