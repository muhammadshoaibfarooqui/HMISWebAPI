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
    public class AreaSetupNewController : ControllerBase
    {
        private readonly IAreaSetupNew _areaSetupNew;
        public AreaSetupNewController(IAreaSetupNew areaSetupNew)
        {
            _areaSetupNew = areaSetupNew;
        }
    
        [HttpGet]
        [Route("GetAreaSetupNewAll")]
        public async Task<ActionResult> GetAreaSetupNewAll()
        {
            try
            {
                //return Ok(await _employeeRepository.GetEmployees());
                return Ok(await _areaSetupNew.GetAreaSetupNewAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetAreaSetupNewId")]
        public async Task<ActionResult<AreaSetupNewVM>> GetAreaSetupNewId(string Id)
        {
            try
            {
                var result = await _areaSetupNew.GetAreaSetupNewId(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpGet]
        [Route("GetAreaSetupNewByIdAll")]
        public async Task<ActionResult<AreaSetupNew>> GetAreaSetupNewByIdAll(string Id)
        {
            try
            {
                var result = await _areaSetupNew.GetAreaSetupNewByIdAll(Id);
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpPost]
        [Route("InsertAreaSetupNew")]
        public async Task<ActionResult<AreaSetupNew>> InsertAreaSetupNew(AreaSetupNew areaSetupNew)
        {
            try
            {
                if (areaSetupNew == null)
                {
                    return BadRequest();
                }
                var insertAreaSetupNew = await _areaSetupNew.InsertAreaSetupNew(areaSetupNew);
                return CreatedAtAction(nameof(GetAreaSetupNewAll), new { Id = insertAreaSetupNew.AreaCode }, insertAreaSetupNew);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");

            }
        }

        [HttpPut]
        [Route("UpdateAreaSetupNew")]
        //public async Task<ActionResult<AreaSetupNew>> UpdateAreaSetupNew(string Id, AreaSetupNew areaSetupNew)
        //{
        //    try
        //    {
        //        if (Id != areaSetupNew.AreaCode)
        //        {
        //            return BadRequest("Id Mismatched");
        //        }
        //        var updateAreaSetupNew = await _areaSetupNew.GetAreaSetupNewId(Id);
        //        if (updateAreaSetupNew == null)
        //        {
        //            return NotFound($"Employee employee.Id ={Id} Not Found");
        //        }
        //        var employeeUpdate = await _areaSetupNew.UpdateAreaSetupNew(areaSetupNew);
        //        return employeeUpdate;
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
        //    }
        //}

        public async Task<ActionResult<AreaSetupNew>> UpdateAreaSetupNew(string Id, AreaSetupNewDTO areaSetupNewDTO)
        {
            try
            {
                if (String.IsNullOrEmpty(Id))
                {
                    return BadRequest("Id Mismatched");
                }
                var updateAreaSetupNew = await _areaSetupNew.GetAreaSetupNewByIdAll(Id);
                if (updateAreaSetupNew == null)
                {
                    return NotFound($"Area Setup area.Id ={Id} Not Found");
                }
                var areaSetupNewUpdate = await _areaSetupNew.UpdateAreaSetupNew(Id,areaSetupNewDTO);
                return areaSetupNewUpdate;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Data is not retrieving from database");
            }
        }

        [HttpDelete]
        [Route("DeleteAreaSetupNew")]
        public async Task<ActionResult<AreaSetupNew>> DeleteAreaSetupNew(string Id)
        {
            var employeeDelete = await _areaSetupNew.DeleteAreaSetupNew(Id);
            if (employeeDelete == null)
            {
                return NotFound($"Employee Id = {Id} Not Found");
            }
            return await _areaSetupNew.DeleteAreaSetupNew(Id);
        }
    }
}
