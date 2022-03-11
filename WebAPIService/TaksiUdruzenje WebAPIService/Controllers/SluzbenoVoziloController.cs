using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TaksiUdruzenjeLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaksiUdruzenje_WebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SluzbenoVoziloController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSvaSluzbenaVozila")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSvaSluzbena()
        {
            try
            {
                return new JsonResult(DataProvider.GetSluzbenaVozilaAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSluzbenoVozilo/{idSluzbenogVozila}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSluzbenoVozilo(int idSluzbenogVozila)
        {
            try
            {
                DTO.SluzbenoVoziloPregled sluzbeno = DataProvider.vratiSluzbenoVozilo(idSluzbenogVozila);
                if (sluzbeno != null)
                    return new JsonResult(sluzbeno);
                else
                    return BadRequest("Ne postoji sluzbeno vozilo sa ovim id-em.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSluzbenoVozilo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DodajSluzbenoVozilo([FromBody] DTO.SluzbenoVoziloPregled vozilo)
        {
            try
            {
                if (DataProvider.createSluzbeno(vozilo.RegOznaka, vozilo.Marka, vozilo.Tip,
                    vozilo.DatumIstekaRegistracije,
                    vozilo.GodinaProizvodnje))
                    return Ok();
                else
                    return BadRequest("Greska prilikom dodavanja. Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiVozioSluzbeno/{idVeze}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiVozioSluzbeno(int idVeze)
        {
            try
            {
                if (DataProvider.DeleteVozioOd(idVeze))
                    return Ok();
                else
                    return BadRequest("Ne postoji entitet sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("IzmeniSluzbenoVozilo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzmeniSluzbenoVozilo([FromBody] DTO.SluzbenoVoziloPregled vozilo)
        {
            try
            {
                if (DataProvider.EditSluzbenoVozilo(vozilo))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene sluzbenog vozila! Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiSluzbenoVozilo/{idSluzbenogVozila}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiSluzbenoVozilo(int idSluzbenogVozila)
        {
            try
            {
                if (DataProvider.obrisiSluzbenoVozilo(idSluzbenogVozila))
                    return Ok();
                else
                    return BadRequest("Ne postoji sluzbeno vozilo sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
