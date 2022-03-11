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
    public class MusterijaTelefoniController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveTelefone")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveTelefone()
        {
            try
            {
                return new JsonResult(DataProvider.GetTelefoniAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiTelefon/{idTelefona}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTelefon(int idTelefona)
        {
            try
            {
                DTO.TelefoniPregled tel = DataProvider.GetTelefon(idTelefona);
                if (tel == null)
                    return BadRequest("Ne postoji telefon sa ovim id-em.");

                return new JsonResult(tel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiTelefoneMusterije/{idMusterije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTelefoniMusterije(int idMusterije)
        {
            try
            {
                return new JsonResult(DataProvider.GetTelefoniMusterije(idMusterije));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTelefon")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //dodajemo novi telefon nekoj musteriji
        public IActionResult DodajTelefon([FromBody] DTO.TelefoniPregled telefon)
        {
            try
            {
                if (DataProvider.DodajTelefon(telefon))
                    return Ok();
                else
                    return BadRequest("Greska prilikom dodavanja. Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniTelefon")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //menjamo telefon (broj telefona I musteriju)
        public IActionResult IzmeniTelefon([FromBody] DTO.TelefoniPregled telefon)
        {
            try
            {
                if (DataProvider.IzmeniTelefon(telefon))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene telefona! Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiTelefon/{idTelefona}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //brisanje telefona po id-u
        public IActionResult ObrisiTelefon(int idTelefona)
        {
            try
            {
                if (DataProvider.ObrisiTelefon(idTelefona))
                    return Ok();
                else
                    return BadRequest("Ne postoji telefon sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiTelefonPoBroju/{brTelefona}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //brisanje telefona po broju telefona
        public IActionResult ObrisiTelefonPoBroju(string brTelefona)
        {
            try
            {
                if (DataProvider.ObrisiTelefonPoBroju(brTelefona))
                    return Ok();
                else
                    return BadRequest("Ne postoji uneti broj!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
