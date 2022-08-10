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
    public class DatosPersonalesController : ControllerBase
    {

        private readonly IDataRepositoryDatosPersonales dapersonales;

        public DatosPersonalesController(IDataRepositoryDatosPersonales idapersonales)
        {

            dapersonales = idapersonales;
        }

        // GET: api/<DatosPersonalesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DatosPersonalesController>/5
        [HttpGet("{IdDato}")]
        public IActionResult GetById(int IdDato)
        {
            return Ok(dapersonales.GetDatosPersonales(IdDato));
        }

        // POST api/<DatosPersonalesController>
        [HttpPost]
        public IActionResult PostDatosPersonaes([FromBody] DatosPersonale item)
        {
            try
            {

                if (item == null || !ModelState.IsValid)
                {
                    return BadRequest("Error: Envio de datos");
                }

                dapersonales.PostDatosPersonales(item);

            }
            catch (Exception ex)
            {
                return BadRequest("Error:" + ex.Message);
            }

            return Ok(item.IdDato);

        }

        // PUT api/<DatosPersonalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DatosPersonalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
