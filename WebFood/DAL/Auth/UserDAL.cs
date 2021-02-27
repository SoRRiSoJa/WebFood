using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFood.DAL.Abstractions;
using WebFood.Data;
using WebFood.Model.Auth;

namespace WebFood.DAL.Auth
{
    /// <summary>
    /// Classe de acesso a dados do Usuário
    /// </summary>
    public class UserDAL : IUserDAL
    {
        private readonly IDapper _ContextDB;
        /// <summary>
        /// Metodo consstrutor da classe
        /// </summary>
        /// <param name="_ContextDB"></param>
        public UserDAL(IDapper _ContextDB)
        {
            this._ContextDB = _ContextDB ?? throw new ArgumentNullException(nameof(_ContextDB));
        }
        /// <summary>
        /// Exclui um usuário do banco
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Recupera um usuário do banco pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetById(Guid? id)
        {
            try
            {
                using (var db = _ContextDB.GetDbconnection())
                {
                    await db.OpenAsync();
                    var user = await db.QueryFirstOrDefaultAsync<User>($@"
                        SELECT * FROM User  
                        WHERE Id=@Id", new { Id = id });
                    await  db.CloseAsync();
                    
                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao recuperar registro:{ex.Message}");
                return null;
            }
        }
        /// <summary>
        /// Recupera um usuário por seu login e senha  
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<User> GetByNameAndPassword(string userName, string password)
        {
            try
            {
                using (var db = _ContextDB.GetDbconnection())
                {
                    await db.OpenAsync();
                    var user = await db.QueryFirstOrDefaultAsync<User>($@"
                        SELECT * FROM [dbo].[User]  
                        WHERE Username=@Username AND Password=@Password", new { Username = userName, Password=password });
                    await db.CloseAsync();

                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao recuperar registro:{ex.Message}");
                return null;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insere um novo usuário no banco
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public async Task<bool> Insert(User o)
        {
            try
            {
                using (var db = _ContextDB.GetDbconnection())
                {
                    await db.OpenAsync();
                    await db.ExecuteAsync(@"INSERT INTO [dbo].[User]([Username],[Password],[Salt],[Iteractions],[Role]) VALUES (@a,@b,@c,@d,@e)", new { a = o.Username, b = o.Password, c = o.Salt, d = o.Iteractions, e = o.Role });
                    await db.CloseAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao recuperar registro:{ex.Message}");
                return false;
            }
        }
        /// <summary>
        /// Recupera todos os usuários do Banco
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<User>> ListALL()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Atualiza o registro de um usuário
        /// </summary>
        /// <param name="id"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public Task<bool> Update(Guid id, User o)
        {
            throw new NotImplementedException();
        }
    }
}
