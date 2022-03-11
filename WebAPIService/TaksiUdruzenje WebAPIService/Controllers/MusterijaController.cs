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
    public class MusterijaController : ControllerBase
    {

        [HttpGet]
        [Route("GetMusterije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMusterije()
        {
            try
            {
                return new JsonResult(DataProvider.GetMusterijaAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetMusterija/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMusterija(int id)
        {
            try
            {
                DTO.MusterijaPregled musterija = DataProvider.GetMusterija(id);
                if(musterija!=null)
                    return new JsonResult(musterija);
                else
                    return BadRequest("Ne postoji musterija sa ovim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddMusterija")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddMusterija([FromBody] DTO.MusterijaPregled musterija)
        {
            try
            {
                
                if(DataProvider.DodajMusteriju(musterija))
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
        [Route("IzmeniMusteriju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniMusteriju([FromBody] DTO.MusterijaPregled musterija)
        {
            try
            {

                if (DataProvider.IzmeniMusteriju(musterija.IdMusterije,musterija.Ime,musterija.Prezime,musterija.Adresa,musterija.BrojVoznji))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene musterije. Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("ObrisiMusteriju/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ObrisiMusteriju([FromRoute(Name = "id")] int id)
        {
            try
            {
                if(DataProvider.obrisiMusteriju(id))
                    return Ok();
                else
                    return BadRequest("Ne postoji musterija sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
