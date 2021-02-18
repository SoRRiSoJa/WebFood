using System.Threading.Tasks;
using WebFood.Model.Auth;

namespace WebFood.Service.Abstractions
{
    /// <summary>
    /// Interface de abstração do serviõ de autenticação
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Recupera um usuário pelo seu login e senha
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<User> GetByNameAndPassword(string userName,string password);
    }
}
