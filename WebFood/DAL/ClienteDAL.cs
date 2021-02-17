using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebFood.DAL
{
    using Dapper;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Text;
    using WebFood.DAL.Abstractions;
    using WebFood.Data;
    using WebFood.Model.Cliente;
    /// <summary>
    /// Implementação da classe de acesso a dados docliente
    /// </summary>
    public class ClienteDAL : IClienteDAL
    {
        private readonly IDapper _ContextDB;
        /// <summary>
        /// Método contrutor
        /// </summary>
        /// <param name="_ContextDB"></param>
        public ClienteDAL(IDapper _ContextDB)
        {
            this._ContextDB = _ContextDB ?? throw new ArgumentNullException(nameof(_ContextDB));
        }
        /// <summary>
        /// Exclui um registro da tabela de clientes
        /// </summary>
        /// <param name="id">Id do cliente</param>
        /// <returns></returns>
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Recupera o registro de um cliente dado seu Id
        /// </summary>
        /// <param name="id">Id do cliente</param>
        /// <returns></returns>

        public async Task<Cliente> GetById(Guid? id)
        {
            try
            {
                using (var db = _ContextDB.GetDbconnection())
                {

                    await db.OpenAsync();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT C.*,T.*,E.* FROM Cliente C ");
                    sql.Append("LEFT JOIN ClienteTelefone CT ON C.Id=CT.ClienteId ");
                    sql.Append("LEFT JOIN ClienteEndereco CE ON C.Id=CE.ClienteId ");
                    sql.Append("LEFT JOIN Telefone T ON CT.TelefoneId=T.Id ");
                    sql.Append("LEFT JOIN Endereco E ON E.ID=CE.EnderecoId ");
                    sql.Append("WHERE C.Id='");
                    sql.Append(id);
                    sql.Append('\''); 
                    List <Cliente> datas = new List<Cliente>();
                    db.Query<Cliente, Telefone, Cliente>(sql.ToString(), (c, t) =>
                    {
                        if (c.Telefone == null) c.Telefone = new List<Telefone>();
                         c.Telefone.Add(t);
                        var r = datas.FirstOrDefault(x => x.Id == t.Id);
                        if (r != null)
                        {
                            r.Telefone.Add(t);
                        }
                        else
                        {
                            datas.Add(c);
                        }
                        return c;
                    }, splitOn: "Id, Id");
                    




                    var clientes = await db.QueryFirstOrDefaultAsync<Cliente>($@"
                        SELECT C.*,T.*,E.* FROM Cliente C 
                        LEFT JOIN ClienteTelefone CT ON C.Id=CT.ClienteId
                        LEFT JOIN ClienteEndereco CE ON C.Id=CE.ClienteId
                        LEFT JOIN Telefone T ON CT.TelefoneId=T.Id
                        LEFT JOIN Endereco E ON E.ID=CE.EnderecoId
                        WHERE C.Id=@Id", new { Id = id });
                    return clientes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao recuperar registro:{ex.Message}");
                return null;
            }
        }



        /// <summary>
        /// Insere um novo registro de cliente
        /// </summary>
        /// <param name="o">Objeto do tipo CLiente</param>
        /// <returns></returns>
        public Task<bool> Insert(Cliente o)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Recupera uma lista de todos os clientes
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Cliente>> ListALL()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Altera os dados de um registro de cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public Task<bool> Update(Guid id, Cliente o)
        {
            throw new NotImplementedException();
        }
    }
}
