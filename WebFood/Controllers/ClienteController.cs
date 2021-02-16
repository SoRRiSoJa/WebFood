using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebFood.Controllers
{
    using System.Threading.Tasks;
    using WebFood.DAL.Abstractions;
    using WebFood.DTO.Cliente;
    using WebFood.Model.Cliente;

    /// <summary>
    /// Api de operaçoes  CRUD para Entidade Cliente
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteDAL ClienteDAL;
        /// <summary>
        /// Metodo contrutor
        /// </summary>
        /// <param name="ClienteDAL"></param>
        public ClienteController(IClienteDAL ClienteDAL)
        {
            this.ClienteDAL = ClienteDAL ?? throw new ArgumentNullException(nameof(ClienteDAL));
        }
        
        

        /// <summary>
        /// Retorna uma lista com todos os clientes
        /// </summary>
        /// <returns>IEnumerable<Cliente></Cliente></returns>
        [HttpGet]
        public IEnumerable<ClienteDTO> ListAll()
        {
            return new List<ClienteDTO>();
        }

        
        /// <summary>
        /// Recupera um cliente pelo seu Id
        /// </summary>
        /// <param name="Id">Guid id do Cliente </param>
        /// <returns></returns>
        [HttpGet(nameof(GetById))]
        public async Task<IEnumerable<Cliente>> GetById(Guid Id)
        {
            
            return await ClienteDAL.GetById(Id);
        }

        /// <summary>
        /// Insere um novo cliente a partir de um formulário
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        /// <summary>
        /// Atualiza um registro de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Exclui o registro de um cliente
        /// </summary>
        /// <param name="id">Guid id do registro do cliente</param>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
