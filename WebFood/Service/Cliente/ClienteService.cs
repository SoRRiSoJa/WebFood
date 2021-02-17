using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace WebFood.Service
{
    using WebFood.DAL.Abstractions;
    using WebFood.Model.Cliente;
    using WebFood.Service.Abstractions;


    /// <summary>
    /// Classe de serviço do cliente
    /// </summary>
    public class ClienteService:IClienteService
    {
        private readonly IClienteDAL ClienteDAL;
        /// <summary>
        /// Metodo contrutor
        /// </summary>
        /// <param name="ClienteDAL"></param>
        public ClienteService(IClienteDAL ClienteDAL)
        {
            this.ClienteDAL = ClienteDAL ?? throw new ArgumentNullException(nameof(ClienteDAL));
        }

        /// <summary>
        /// Recupera o registro de um cliente por Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Cliente> GetById(Guid? Id)
        {
            return await ClienteDAL.GetById(Id);
        }
        /// <summary>
        /// Recupera uma lista completa dos clientes 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Cliente>> ListAll()
        {
            return await ClienteDAL.ListALL();
        }
    }
}
