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
    public class DatosContactoController : ControllerBase
    {
        private readonly IDataRepositoryDatosContacto dacontacto;

        public DatosContactoController(IDataRepositoryDatosContacto idacontacto)
        {

            dacontacto = idacontacto;
        }

        // GET: api/<DatosContactoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DatosContactoController>/5
        [HttpGet("{IdDato}")]
        public IActionResult GetById(int IdDato)
        {
            return Ok(dacontacto.GetDatosContacto(IdDato));
        }

        // POST api/<DatosContactoController>
        [HttpPost]
        public IActionResult PostDatos([FromBody] DatosContacto item)
        {
            try
            {

                if (item == null || !ModelState.IsValid)
                {
                    return BadRequest("Error: Envio de datos");
                }

                dacontacto.PostDatosContacto(item);

            }
            catch (Exception ex)
            {
                return BadRequest("Error:" + ex.Message);
            }

            return Ok(item.IdDato);

        }


        // PUT api/<DatosContactoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DatosContactoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
