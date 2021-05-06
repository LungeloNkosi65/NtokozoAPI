using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sports_Api.Models;
using Sports_Api.Models.CRUD_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterMakesController : ControllerBase
    {
        private ICrudMakeLogic _makeCrudLogic;
        public PrinterMakesController(ICrudMakeLogic marketCrudLogic)
        {
            _makeCrudLogic = marketCrudLogic;
        }
        [HttpGet]
        public IActionResult GetSingleMake(int? makeId)
        {
            try
            {
                var results = _makeCrudLogic.GetMakeById(makeId);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAllMakes")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _makeCrudLogic.GettAllMakes().ToList();
                return Ok(results);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("AddMake")]
        public IActionResult AddMake(Make make)
        {
            try
            {
                _makeCrudLogic.AddMake(make);
                return Ok("Make Added Successfully");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteMake(int? makeId)
        {
            try
            {
                _makeCrudLogic.DeleteMake(makeId);
                return Ok("Make Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateMake(Make make)
        {
            try
            {
                _makeCrudLogic.UpdateMake(make);
                return Ok("Make Successfully Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
