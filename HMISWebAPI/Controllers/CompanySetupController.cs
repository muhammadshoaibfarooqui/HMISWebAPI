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
    public class CompanySetupController : ControllerBase
    {
        private readonly ICompanySetup _companySetup;
        public CompanySetupController(ICompanySetup companySetup)
        {
            _companySetup = companySetup;
        }

        [HttpGet]
        [Route("GetCompanySetupAll")]
        public async Task<ActionResult> GetCompanySetupAll()
        {
            try
            {
                //return Ok(await _employeeRepository.GetEmployees());
                return Ok(await _companySetup.GetCompanySetupAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetCompanySetupById")]
        public async Task<ActionResult<CompanySetup>> GetCompanySetupById(string Id)
        {
            try
            {
                var result = await _companySetup.GetCompanySetupById(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpPost]
        [Route("InsertCompanySetup")]
        public async Task<ActionResult<CompanySetup>> InsertCompanySetup(CompanySetup companySetup)
        {
            try
            {
                if (companySetup == null)
                {
                    return BadRequest();
                }
                var insertCompanySetup = await _companySetup.InsertCompanySetup(companySetup);
                return CreatedAtAction(nameof(GetCompanySetupAll), new { Id = insertCompanySetup.CmpnyCode }, insertCompanySetup);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");

            }
        }

        [HttpPut]
        [Route("UpdateCompanySetup")]
        public async Task<ActionResult<CompanySetup>> UpdateCompanySetup(string Id, CompanySetupDTO companySetup)
        {
            try
            {
                if (String.IsNullOrEmpty(Id) /*companySetup.CmpnyCode*/)
                {
                    return BadRequest("Id Mismatched");
                }
                var updateCompanySetup = await _companySetup.GetCompanySetupById(Id);
                if (updateCompanySetup == null)
                {
                    return NotFound($"CompanySetup companySetup.CmpnyCode ={Id} Not Found");
                }
                var companySetupUpdate = await _companySetup.UpdateCompanySetup(Id,companySetup);
                return companySetupUpdate;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpDelete]
        [Route("DeleteCompanySetup")]
        public async Task<ActionResult<CompanySetup>> DeleteCompanySetup(string Id)
        {
            var companySetupDelete = await _companySetup.DeleteCompanySetup(Id);
            if (companySetupDelete == null)
            {
                return NotFound($"CompanySetup CmpnyCode = {Id} Not Found");
            }
            return await _companySetup.DeleteCompanySetup(Id);
        }
    }
}
