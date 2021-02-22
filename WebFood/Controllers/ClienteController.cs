using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebFood.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using System.Collections.Generic;
    using WebFood.Model.Cliente;
    using WebFood.Service.Abstractions;

    /// <summary>
    /// Api de operaçoes  CRUD para Entidade Cliente
    /// </summary>
    [Authorize]
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService ClienteService;
        /// <summary>
        /// Método construtor da classe
        /// </summary>
        /// <param name="ClienteService"></param>
        public ClienteController(IClienteService ClienteService)
        {
            this.ClienteService = ClienteService ?? throw new ArgumentNullException(nameof(ClienteService));
        }

        /// <summary>
        /// Retorna uma lista com todos os clientes
        /// </summary>
        /// <returns>IEnumerable<Cliente></Cliente></returns>
        [HttpGet("ListAll")]
        [ProducesResponseType(typeof(IEnumerable<Cliente>), StatusCodes.Status200OK)]
        public async Task<IActionResult> ListAll()
        {
            return Ok(await ClienteService.ListAll());
        }

        /// <summary>
        /// Recupera um cliente pelo seu Id
        /// </summary>
        /// <param name="Id">Guid id do Cliente </param>
        /// <returns></returns>

        [HttpGet("GetById/{Id}")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(Guid? Id)
        {
            if (Id is null)
                throw new ArgumentNullException(nameof(Id));
            try
            {
                var data = await ClienteService.GetById(Id);
                return Ok(data);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }
        }
                    
    }
}
