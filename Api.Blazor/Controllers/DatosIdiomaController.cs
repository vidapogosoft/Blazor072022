using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Blazor.Interfaces.Registro;
using Model.Blazor.Models.Database;

using Microsoft.AspNetCore.Authorization;

namespace Api.Blazor.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DatosIdiomaController : ControllerBase
    {
        private readonly IDataRepositoryDatosIdiomas daidiomas;

        public DatosIdiomaController(IDataRepositoryDatosIdiomas idaidiomas)
        {

            daidiomas = idaidiomas;
        }

        // GET: api/<DatosIdiomaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DatosIdiomaController>/5
        [HttpGet("{IdDato}")]
        public IActionResult GetById(int IdDato)
        {
            return Ok(daidiomas.GetDatosIdiomas(IdDato));
        }

        // POST api/<DatosIdiomaController>
        [HttpPost]
        public IActionResult PostDatos([FromBody] DatosIdioma item)
        {
            try
            {

                if (item == null || !ModelState.IsValid)
                {
                    return BadRequest("Error: Envio de datos");
                }

                daidiomas.PostDatosIdiomas(item);

            }
            catch (Exception ex)
            {
                return BadRequest("Error:" + ex.Message);
            }

            return Ok(item.IdDato);

        }


        // PUT api/<DatosIdiomaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DatosIdiomaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
