using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFood.Model.Auth
{
    /// <summary>
    /// Classe que representa o usuário do sistema
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id do usuário
        /// </summary>
        public int IdUser { get; set; }
        /// <summary>
        /// Login do usuario
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Senha
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// nivel
        /// </summary>
        public string Role { get; set; }
    }
}
