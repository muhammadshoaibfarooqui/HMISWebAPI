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
    public class CitySetupController : ControllerBase
    {
        private readonly ICitySetup _citySetup;
        public CitySetupController(ICitySetup citySetup)
        {
            _citySetup = citySetup;
        }

        [HttpGet]
        [Route("GetCitySetupAll")]
        public async Task<ActionResult> GetCitySetupAll()
        {
            try
            {
                //return Ok(await _employeeRepository.GetEmployees());
                return Ok(await _citySetup.GetCitySetupAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetCitySetupByIdAll")]
        public async Task<ActionResult<CitySetup>> GetCitySetupByIdAll(string Id)
        {
            try
            {
                var result = await _citySetup.GetCitySetupByIdAll(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetCitySetupById")]
        public async Task<ActionResult<CitySetupDTO>> GetCitySetupById(string Id)
        {
            try
            {
                var result = await _citySetup.GetCitySetupById(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpPost]
        [Route("InsertCitySetup")]
        public async Task<ActionResult<CitySetup>> InsertCitySetup(CitySetup citySetup)
        {
            try
            {
                if (citySetup == null)
                {
                    return BadRequest();
                }
                var insertCitySetup = await _citySetup.InsertCitySetup(citySetup);
                return CreatedAtAction(nameof(GetCitySetupAll), new { Id = insertCitySetup.CityCode }, insertCitySetup);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");

            }
        }

        [HttpPut]
        [Route("UpdateCitySetup")]
        //public async Task<ActionResult<CitySetup>> UpdateCitySetup(string Id, CitySetup citySetup)
        //{
        //    try
        //    {
        //        if (Id != citySetup.CityCode)
        //        {
        //            return BadRequest("Id Mismatched");
        //        }
        //        var updateCitySetup = await _citySetup.GetCitySetupById(Id);
        //        if (updateCitySetup == null)
        //        {
        //            return NotFound($"Employee employee.Id ={Id} Not Found");
        //        }
        //        var employeeUpdate = await _citySetup.UpdateCitySetup(citySetup);
        //        return employeeUpdate;
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
        //    }
        //}

        public async Task<ActionResult<CitySetup>> UpdateCitySetup(string Id, CitySetup citySetup)
        {
            try
            {
                if (String.IsNullOrEmpty(Id))
                {
                    return BadRequest("Id Mismatched");
                }
                var updateCitySetup = await _citySetup.GetCitySetupById(Id);
                if (updateCitySetup == null)
                {
                    return NotFound($"City Setup city.Id ={Id} Not Found");
                }
                var citySetupUpdate = await _citySetup.UpdateCitySetup(Id,citySetup);
                return citySetupUpdate;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpDelete]
        [Route("DeleteCitySetup")]
        public async Task<ActionResult<CitySetup>> DeleteCitySetup(string Id)
        {
            var employeeDelete = await _citySetup.DeleteCitySetup(Id);
            if (employeeDelete == null)
            {
                return NotFound($"CitySetup Id = {Id} Not Found");
            }
            return await _citySetup.DeleteCitySetup(Id);
        }
    }
}
