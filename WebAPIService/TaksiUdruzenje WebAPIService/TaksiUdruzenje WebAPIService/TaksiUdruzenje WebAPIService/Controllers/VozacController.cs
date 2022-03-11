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
    public class VozacController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveVozace")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public IActionResult GetVozacAll()
        {
            try
            {
                return new JsonResult(DataProvider.GetVozacAll());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

         [HttpGet]
         [Route("PreuzmiVozaca/{idVozaca}")]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]

         public IActionResult GetVozac(int idVozaca)
         {
             try
             {
                DTO.VozacPregled vp = null;
                vp = DataProvider.GetVozac(idVozaca);
                if (vp!= null)
                    return new JsonResult(vp);
                else
                    return BadRequest("Ne postoji vozac sa ovim id-em!");
               
            }
             catch (Exception ex)
             {
                 return BadRequest(ex.ToString());
             }
         }


        [HttpPost]
        [Route("DodajVozaca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult DodajVozaca([FromBody]DTO.VozacPregled vozac)
        {
            try
            {
                if(DataProvider.CreateVozac(vozac.Ime, vozac.SrednjeSlovo, vozac.Prezime, vozac.Jmbg, vozac.BrojTelefona, vozac.Ulica, vozac.Broj, vozac.BrojDozvole, vozac.Kategorija))
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
        [Route("IzmeniVozaca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult IzmeniVozaca([FromBody] DTO.VozacPregled vozac)
        {
            try
            {
                if (DataProvider.izmeniVozaca(vozac.IdVozac, vozac.Ime,vozac.Prezime, vozac.SrednjeSlovo, vozac.Ulica, vozac.Broj, vozac.BrojTelefona, vozac.Kategorija,vozac.BrojDozvole))
                    return Ok();
                else
                    return BadRequest("Greska prilikom izmene vozaca! Proverite podatke koje se uneli.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiVozaca/{idVozaca}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult ObrisiVozaca(int idVozaca)
        {
            try
            {
                if (DataProvider.deleteVozac(idVozaca))
                    return Ok();
                else
                    return BadRequest("Ne postoji vozac sa prosledjeni id-em!");

                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
