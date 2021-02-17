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

                    StringBuilder query = new StringBuilder();
                    query.Append("SELECT C.*,T.*,E.* FROM Cliente C ");
                    query.Append("LEFT JOIN ClienteTelefone CT ON C.Id=CT.ClienteId ");
                    query.Append("LEFT JOIN ClienteEndereco CE ON C.Id=CE.ClienteId ");
                    query.Append("LEFT JOIN Telefone T ON CT.TelefoneId=T.Id ");
                    query.Append("LEFT JOIN Endereco E ON E.ID=CE.EnderecoId ");
                    query.Append("WHERE C.Id=@Id");
                    var minhaRolaNoSelect = db.Query<Cliente, Telefone,Endereco,Cliente>
                        (query.ToString(),
                                         (cli, tel,end) =>
                                         {
                                             cli.Telefone ??= new List<Telefone>();
                                             if (!cli.Telefone.Contains(tel))
                                                 cli.Telefone.Add(tel);
                                             cli.Endereco ??= new List<Endereco>();
                                             if(!cli.Endereco.Contains(end))
                                                cli.Endereco.Add(end);
                                             return cli;
                                         },
                                         new { Id = id },
                                         splitOn: "Nome,Id"
                                         
                                     ).GroupBy(o => o.Id)
                                      .Select(group =>
                                      {
                                          var combinedCliente = group.First();
                                          combinedCliente.Telefone = group.Select(cli => cli.Telefone.Single()).ToList();
                                          combinedCliente.Endereco = group.Select(cli => cli.Endereco.Single()).ToList();
                                          return combinedCliente;
                                      }).FirstOrDefault();
                    return minhaRolaNoSelect;
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
