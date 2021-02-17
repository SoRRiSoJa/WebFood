using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebFood.DAL.Abstractions
{
    /// <summary>
    /// Generaização da logica de acesso a dados
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericDAL<T>
    {
        /// <summary>
        /// Listar todos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> ListALL();
        /// <summary>
        /// Buscar pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetById(Guid? id);
        /// <summary>
        /// Inserir novo registro na base
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        Task<bool> Insert(T o);
        /// <summary>
        /// Alterar um registro na base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        Task<bool> Update(Guid id, T o);
        /// <summary>
        /// Excluir um registro na base
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(Guid id);
    }
}
