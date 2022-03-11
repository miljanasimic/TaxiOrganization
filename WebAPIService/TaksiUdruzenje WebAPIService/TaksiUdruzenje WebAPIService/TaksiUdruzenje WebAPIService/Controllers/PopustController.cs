using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaksiUdruzenjeLibrary;
namespace TaksiUdruzenje_WebAPIService.Controllers
{
    public class PopustController : Controller
    {
        [HttpGet]
        [Route("GetPopusti")]
        public IActionResult GetPopusti()
        {
            try
            {
                return new JsonResult(TaksiUdruzenjeLibrary.DataProvider.GetPopustAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetPopustiMusterije/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetPopustiMusterije(int id)
        {
            try
            {
                return new JsonResult(TaksiUdruzenjeLibrary.DataProvider.GetPopustMusterije(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddPopust")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPopust([FromBody] DTO.PopustPregled popust)
        {
            try
            {
                DataProvider.addPopust(popust.IdMusterije.IdMusterije, popust.Vrednost, popust.DatumPocetka, popust.DatumKraja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("ObrisiPopust/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiPopust([FromRoute(Name = "id")] int id)
        {
            try
            {
                DataProvider.obrisiPopust(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPut]
        [Route("ProduziPopust")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ProduziPopust([FromBody] DTO.PopustPregled popust)
        {
            try
            {
                DataProvider.ProduziPopust(popust.Id, popust.DatumKraja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
