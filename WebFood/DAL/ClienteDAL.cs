﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebFood.DAL
{
    using Dapper;
    using System.Data;
    using WebFood.DAL.Abstractions;
    using WebFood.Data;
    using WebFood.DTO.Cliente;
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
        public async Task<IEnumerable<Cliente>> GetById(Guid id)
        {
            var tt = new Guid("77C1FD6D-7476-4F56-B969-20176E1D5934");
            using (var db = _ContextDB.GetDbconnection())
            {

                await db.OpenAsync();
                var query = $@"
                SELECT C.*,T.*,E.* FROM Cliente C 
                LEFT JOIN ClienteTelefone CT ON C.Id=CT.ClienteId
                LEFT JOIN ClienteEndereco CE ON C.Id=CE.ClienteId
                LEFT JOIN Telefone T ON CT.TelefoneId=T.Id
                LEFT JOIN Endereco E ON E.ID=CE.EnderecoId
                WHERE C.Id='{tt}'";
                var clientes = await db.QueryAsync<Cliente>(query);
                
                return clientes;
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
