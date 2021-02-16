using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebFood.Controllers
{
    using WebFood.DTO.Cliente;
    /// <summary>
    /// Api de operaçoes  CRUD para Entidade Cliente
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        /// <summary>
        /// Retorna uma lista com todos os clientes
        /// </summary>
        /// <returns>IEnumerable<Cliente></Cliente></returns>
        [HttpGet]
        public IEnumerable<ClienteDTO> ListAll()
        {
            return new List<ClienteDTO>();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public ClienteDTO Get(Guid id)
        {
            return new ClienteDTO();
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
