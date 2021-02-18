using System;
using System.Threading.Tasks;

namespace WebFood.Service.Auth
{
    using WebFood.DAL.Abstractions;
    using WebFood.Model.Auth;
    using WebFood.Service.Abstractions;

    /// <summary>
    /// classe do Serviço de autenticação
    /// </summary>
    public class AuthService : IAuthService
    {
        IUserDAL UserDAL;

        /// <summary>
        /// Método contrutor da classe
        /// </summary>
        public AuthService(IUserDAL UserDAL)
        {
            this.UserDAL = UserDAL ?? throw new ArgumentNullException(nameof(UserDAL));
        }
        /// <summary>
        /// Recupera um usuário dada o login e a senha
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<User> GetByNameAndPassword(string userName, string password)
        {
            return await UserDAL.GetByNameAndPassword(userName, password);
        }
    }
}
