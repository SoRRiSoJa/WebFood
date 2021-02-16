using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebFood.Controllers
{
    using System.Threading.Tasks;
    using WebFood.Model.Cliente;
    using WebFood.Service.Abstractions;

    /// <summary>
    /// Api de operaçoes  CRUD para Entidade Cliente
    /// </summary>
    
    [Route("api/[controller]")]
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
        [HttpGet]
        [HttpGet(nameof(ListAll))]
        public async Task<IEnumerable<Cliente>> ListAll()
        {
            return await ClienteService.ListAll();
        }

        
        /// <summary>
        /// Recupera um cliente pelo seu Id
        /// </summary>
        /// <param name="Id">Guid id do Cliente </param>
        /// <returns></returns>
        
        [HttpGet("{Id}")]
        [HttpGet(nameof(GetById))]
        public async Task<IEnumerable<Cliente>> GetById(Guid Id)
        {
            var t = new Guid("77C1FD6D-7476-4F56-B969-20176E1D5934");
            var tt= await ClienteService.GetById(t);
            return tt;
        }

        /// <summary>
        /// Insere um novo cliente a partir de um formulário
        /// </summary>
        /// <param name="value"></param>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
        ///// <summary>
        ///// Atualiza um registro de um cliente
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="value"></param>
        
        //[HttpPut("{id}")]
        //public void Put(Guid id, [FromBody] string value)
        //{
        //}

        /// <summary>
        /// Exclui o registro de um cliente
        /// </summary>
        /// <param name="id">Guid id do registro do cliente</param>
        
        //[HttpDelete("{id}")]
        //public void Delete(Guid id)
        //{
        //}
    }
}
