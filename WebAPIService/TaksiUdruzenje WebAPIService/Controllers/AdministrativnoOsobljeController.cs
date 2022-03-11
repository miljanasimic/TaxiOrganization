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
    public class AdministrativnoOsobljeController : ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiSvaAdministrativnaOsoblja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult GetAdministrativnoOsobljeAll()
        {
            try
            {
                return new JsonResult(DataProvider.GetAOAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiAdministrativnoOsoblje/{idAdOsoblja}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult GetAdministrativnoOsoblje(int idAdOsoblja)
        {
            try
            {
                DTO.AdministrativnoOsobljePregled ad = null;
                ad = DataProvider.GetAOInfo(idAdOsoblja);
                if (ad != null)
                    return new JsonResult(ad);
                else
                    return BadRequest("Ne postoji administrativno osoblje sa ovim id-em!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAdministrativnoOsoblje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DodajAdministrativnoOsoblje([FromBody] DTO.AdministrativnoOsobljePregled ao)
        {
            try
            {
                if (DataProvider.CreateAdministrativno(ao.Jmbg,ao.Ime,ao.SrednjeSlovo,ao.Prezime,ao.BrojTelefona,ao.Ulica,ao.Broj,ao.StrucnaSprema))
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
        [Route("IzmeniAdministrativnoOsoblje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzmeniAdministrativnoOsoblje([FromBody] DTO.AdministrativnoOsobljePregled ao)
        {
            try
            {
                if (DataProvider.EditAdministrativno(ao.idAO,ao.Ime,ao.Prezime,ao.SrednjeSlovo,ao.Ulica,ao.Broj,ao.BrojTelefona,ao.StrucnaSprema))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene administrativnog osoblja! Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiAdministrativnoOsoblje/{idAdOsoblja}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiAdministrativnoOsoblje(int idAdOsoblja)
        {
            try
            {
                if (DataProvider.obrisiOsoblje(idAdOsoblja))
                    return Ok();
                else
                    return BadRequest("Ne postoji vozac sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
