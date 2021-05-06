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
    public class PrintersController : ControllerBase
    {
        private IPrinterLogic _printerLogic;
        public PrintersController(IPrinterLogic printerLogic)
        {
            _printerLogic = printerLogic;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var results = _printerLogic.GettAllPrinters();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAlVl")]
        public IActionResult GetAllV()
        {
            try
            {
                var results = _printerLogic.GettAllVPrinters();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetSingle(int? printerId)
        {
            try
            {
                var results = _printerLogic.GetPrinterById(printerId);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPrinter(Printer printer)
        {
            try
            {
                printer.CreateDate = DateTime.Now;
                _printerLogic.AddPrinter(printer);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdatePrinter(Printer printer)
        {
            try
            {
                _printerLogic.UpdatePrinter(printer);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeletePrinter(int? printerId)
        {
            try
            {
                _printerLogic.DeletePrinter(printerId);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
