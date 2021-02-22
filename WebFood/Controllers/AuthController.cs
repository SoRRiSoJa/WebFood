using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace WebFood.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using WebFood.Model.Auth;
    using WebFood.Service.Abstractions;
    using WebFood.Service.Auth;

    /// <summary>
    /// Controller de Autenticação
    /// </summary>
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService AuthService;
        /// <summary>
        /// Método contrutor da classe
        /// </summary>
        /// <param name="AuthService"></param>
        public AuthController(IAuthService AuthService)
        {
            this.AuthService=AuthService??  throw new ArgumentNullException(nameof(AuthService));
        }
        /// <summary>
        /// Metodo de autenticação do sistema
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            // Recupera o usuário
            var user = await AuthService.GetByNameAndPassword(model.Username,model.Password);

            // Verifica se o usuário existe
            if (user is null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Oculta a senha
            user.Password = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
