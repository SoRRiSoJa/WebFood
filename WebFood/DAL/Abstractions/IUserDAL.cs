using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFood.Model.Auth;

namespace WebFood.DAL.Abstractions
{
    /// <summary>
    /// Abstração para DAl de Usuário
    /// </summary>
    public interface IUserDAL : IGenericDAL<User>
    {
        /// <summary>
        /// recupera um usuario do banco pelo seu login e senha
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> GetByNameAndPassword(string userName, string password);
    }
}
