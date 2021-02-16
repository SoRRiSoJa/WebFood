using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebFood.DAL.Abstractions
{
    using WebFood.Model.Cliente;
    /// <summary>
    /// Generalização da logica de acesso aos dados do Cliente
    /// </summary>
    public interface IClienteDAL:IGenericDAL<Cliente>
    {
        
    }
}
