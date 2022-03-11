using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaksiUdruzenjeLibrary;
using Microsoft.AspNetCore.Http;

namespace TaksiUdruzenje_WebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PopustController : ControllerBase
    {

        [HttpGet]
        [Route("GetPopusti")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
        [Route("GetPopust/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPopust(int id)
        {
            try
            {
                DTO.PopustPregled p = null;
                p = DataProvider.GetPopust(id);
                if (p != null)
                    return new JsonResult(p);
                else
                    return BadRequest("Ne postoji popust sa ovim id-em!");
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetPopustiMusterije/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                if (DataProvider.addPopust(popust.Musterija.IdMusterije, popust.Vrednost, popust.DatumPocetka, popust.DatumKraja))
                    return Ok();
                else
                    return BadRequest("Greska prilikom dodavanja. Proverite podatke koje se uneli.");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("IzmeniPopust")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniPopust([FromBody] DTO.PopustPregled popust)
        {
            try
            {
                DataProvider.IzmeniPopust(popust);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
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
                if(DataProvider.obrisiPopust(id))
                    return Ok();
                else
                    return BadRequest("Ne postoji popust sa ovim id-em!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
