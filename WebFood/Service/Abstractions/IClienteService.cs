using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFood.Model.Cliente;

namespace WebFood.Service.Abstractions
{
    /// <summary>
    /// Interface do serviço de Clientes
    /// </summary>
    public interface IClienteService
    {
        /// <summary>
        /// Recupera uma lista de todos os clientes
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> ListAll();

        /// <summary>
        /// Recupera um único cliente por Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<IEnumerable<Cliente>> GetById(Guid Id);
    }
}
