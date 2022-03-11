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
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public class MusterijaController : Controller
    {
        [HttpGet]
        [Route("GetMusterije")]
        public IActionResult GetMusterije()
        {
            try
            {
                return new JsonResult(TaksiUdruzenjeLibrary.DataProvider.GetMusterijaAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMusterija/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetMusterija(int id)
        {
            try
            {
                return new JsonResult(TaksiUdruzenjeLibrary.DataProvider.GetMusterija(id));
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
                DataProvider.DodajMusteriju(musterija);
                return Ok();
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
        public IActionResult obrisiMusteriju([FromRoute(Name = "id")] int id)
        {
            try
            {
                DataProvider.obrisiMusteriju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("GetTelefoniMusterija/{Id}")]
        public IActionResult vratiTelefoneMusterije([FromRoute(Name = "id")] int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetTelefoniMusterije(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("DodajTelefon")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddTelefon([FromBody] DTO.TelefoniPregled tp)
        {
            try
            {
                DataProvider.dodajTelefon(tp);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("ObrisiTelefon/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiTelefon([FromRoute(Name = "id")] int id)
        {
            try
            {
                DataProvider.ObrisiTelefon(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("IzmeniVozaca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult IzmeniMusteriju([FromBody] DTO.MusterijaPregled musterija)
        {
            try
            {
                DataProvider.IzmeniMusteriju(musterija.IdMusterije, musterija.Ime, musterija.Prezime, musterija.Adresa);
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
