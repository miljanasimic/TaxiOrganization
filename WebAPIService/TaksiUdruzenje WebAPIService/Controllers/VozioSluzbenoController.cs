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
    public class VozioSluzbenoController : ControllerBase
    {
        
        [HttpGet]
        [Route("PreuzmiSvaVozenaSluzbena")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSvaVozenaSluzbena()
        {
            try
            {
                return new JsonResult(DataProvider.GetVozioSluzbenoAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVozenoSluzbeno/{idVeze}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVozenoSluzbeno(int idVeze)
        {
            try
            {
                DTO.VozioSluzbenoPregled vsp = DataProvider.GetVozioSluzbeno(idVeze);
                if (vsp == null)
                    return BadRequest("Proverite id koji ste uneli.");

                return new JsonResult(vsp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPut]
        [Route("IzmeniVozioSluzbeno")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzmeniVozenoSluzbeno([FromBody] DTO.VozioSluzbenoPregled vsp)
        {
            try
            {
                if (DataProvider.IzmeniVozioSluzbeno(vsp))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene vozenja sluzbenog vozila! Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        //zavrsetak koriscenja sluzbenog vozila
        [HttpPut]
        [Route("ZavrsiKoriscenjeSluzbenog/{idVeze}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ZavrsiKoriscenjeSluzbenog(int idVeze)
        {
            try
            {
                if (DataProvider.UpdateVozioDo(idVeze, DateTime.Now))
                    return Ok();
                else
                    return BadRequest("Greska prilikom zavrsavanja koriscenja. Proverite id koji se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        
        //dodavanje vozila vozacu na odredjeno vreme
        [HttpPost]
        [Route("DodeliVoziloVozacuOdredjeno")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DodeliVoziloVozacuOdredjeno([FromBody] DTO.VozioSluzbenoPregled vs)
        {
            try
            {
                if (vs.VozioOd > vs.VozioDo)
                    return BadRequest("Greska prilikom dodavanja. Proverite uneti datum koriscenja.");

                if (DataProvider.dodeliVoziloVozacu(vs.Vozilo.Id, vs.Vozac.IdVozac, vs.VozioOd, vs.VozioDo))
                    return Ok();
                else
                    return BadRequest("Greska prilikom dodavanja. Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        //dodavanje vozila vozacu na neodredjeno vreme
        [HttpPost]
        [Route("DodeliVoziloVozacuNeodredjeno/{idVozila}/{idVozaca}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DodeliVoziloVozacuNeodredjeno(int idVozila, int idVozaca)
        {
            try
            {
                if (DataProvider.dodeliVoziloVozacu(idVozila, idVozaca, DateTime.Now, null))
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
    }
}
