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
    public class VoznjaController : ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiSveVoznje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult VratiVoznje()
        {
            try
            {
                return new JsonResult(DataProvider.GetVoznjaAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiVoznju/{idVoznje}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult VratiVoznju(int idVoznje)
        {
            try
            {
                DTO.VoznjaPregled vp = DataProvider.GetJednaVoznja(idVoznje);
                if (vp == null)
                    return BadRequest("Ne postoji voznja sa ovim id-em.");

                return new JsonResult(vp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVoznjeMusterije/{idMusterije}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult VratiVoznjuMusterije(int idMusterije)
        {
            try
            {
                List<DTO.VoznjaPregled> vp = DataProvider.GetVoznjeMusterije(idMusterije);
                if (vp == null)
                    return BadRequest("Ne postoji uneta musterija.");

                return new JsonResult(vp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiAktivneVoznjeVozaca/{idVozaca}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult VratiAktivneVoznjeVozac(int idVozaca)
        {
            try
            {
                List<DTO.VoznjaPregled> vp = DataProvider.GetAktivneVoznjeVozaca(idVozaca);
                if (vp == null)
                    return BadRequest("Ne postoji uneti vozac.");

                return new JsonResult(vp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiZavrseneVoznjeVozaca/{idVozaca}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult VratiZavrseneVoznjeVozac(int idVozaca)
        {
            try
            {
                List<DTO.VoznjaPregled> vp = DataProvider.GetZavrseneVoznjeVozaca(idVozaca);
                if (vp == null)
                    return BadRequest("Ne postoji uneti vozac.");

                return new JsonResult(vp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiVoznjeOsoblja/{idOsoblja}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult VratiVoznjeOsoblja(int idOsoblja)
        {
            try
            {
                List<DTO.VoznjaPregled> vp = DataProvider.GetVoznjaAdministrativnog(idOsoblja);
                if (vp == null)
                    return BadRequest("Ne postoji uneti clan osoblja.");

                return new JsonResult(vp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajVoznju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        //dodaje novu voznju cije je vreme kraja i cena null
        public IActionResult DodajNovuVoznju([FromBody] DTO.VoznjaPregled vp)
        {
            try
            {
                if (DataProvider.DodajVoznju(vp))
                    return Ok();
                else
                    return BadRequest("Niste uneli validne informacije!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("ZavrsiVoznju/{idVoznje}/{cena}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        //postavlja vreme kraja voznje na Now i dodaje cenu voznje
        public IActionResult ZavrsiVoznju(int idVoznje, int cena)
        {
            try
            {
                if (DataProvider.ZavrsiVoznju(idVoznje, cena))
                    return Ok();
                else
                    return BadRequest("Ne postoji voznja sa unetim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("IzmeniVoznju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult IzmeniVoznju([FromBody] DTO.VoznjaPregled vp)
        {
            try
            {
                if (DataProvider.IzmeniVoznju(vp))
                    return Ok();
                else
                    return BadRequest("Proverite da li ste uneli dobre podatke! Potrebno je uneti sve podatke!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVoznju/{idVoznje}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiVoznju(int idVoznje)
        {
            try
            {
                if (DataProvider.obrisiVoznju(idVoznje))
                    return Ok();
                else
                    return BadRequest("Ne postoji voznja sa prosledjenim id-em!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
