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
    public class LicnoVoziloController : ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiSvaLicnaVozila")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult GetLicnoVoziloAll()
        {
            try
            {
                return new JsonResult(DataProvider.GetLicnaVozilaAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiLicnoVozilo/{idLicnogVozila}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult GetLicnoVozilo(int idLicnogVozila)
        {
            try
            {
                DTO.LicnoVoziloPregled lv = null;
                lv = DataProvider.GetLicnoVozilo(idLicnogVozila);
                if (lv != null)
                    return new JsonResult(lv);
                else
                    return BadRequest("Ne postoji licno vozilo sa ovim id-em!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajLicnoVozilo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DodajLicnoVozilo([FromBody] DTO.LicnoVoziloPregled lv)
        {
            try
            {
                if (DataProvider.createLicno(lv.Vozac.IdVozac,lv.RegOznaka,lv.Marka,lv.Tip,lv.Boja,lv.KoriscenoOd,lv.KoriscenoDo))
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
        [Route("IzmeniLicnoVozilo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzmeniLicnoVozilo([FromBody] DTO.LicnoVoziloPregled lv)
        {
            try
            {
                if (DataProvider.IzmeniLicnoVozilo(lv.Id,lv.RegOznaka,lv.Marka,lv.Tip,lv.Boja,lv.KoriscenoOd,lv.KoriscenoDo,lv.Vozac))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene licnog vozila! Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiLicnoVozilo/{idLicnogVozila}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiLicnoVozilo(int idLicnogVozila)
        {
            try
            {
                if (DataProvider.obrisiLicnaVozila(idLicnogVozila))
                    return Ok();
                else
                    return BadRequest("Ne postoji licno vozilo sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
