using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Api.Blazor.Interfaces.Registro;
using Model.Blazor.Models.Database;

namespace Api.Blazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosEducacionController : ControllerBase
    {
        private readonly IDataRepositoryDatosEducacion daeducacion;

        public DatosEducacionController(IDataRepositoryDatosEducacion idaeducacion)
        {

            daeducacion = idaeducacion;
        }

        // GET: api/<DatosEducacionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DatosEducacionController>/5
        [HttpGet("{IdDato}")]
        public IActionResult GetById(int IdDato)
        {
            return Ok(daeducacion.GetDatosEducacion(IdDato));
        }

        // POST api/<DatosEducacionController>
        [HttpPost]
        public IActionResult PostDatos([FromBody] DatosEducacion item)
        {
            try
            {

                if (item == null || !ModelState.IsValid)
                {
                    return BadRequest("Error: Envio de datos");
                }

                daeducacion.PostDatosEducacion(item);

            }
            catch (Exception ex)
            {
                return BadRequest("Error:" + ex.Message);
            }

            return Ok(item.IdDato);

        }

        // PUT api/<DatosEducacionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DatosEducacionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
