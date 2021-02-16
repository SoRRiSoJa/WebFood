using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace WebFood.Data
{
    /// <summary>
    /// Abstração do contexto do dapper
    /// </summary>
    public interface IDapper : IDisposable
    {
        /// <summary>
        /// Retorna uma nova conexão com o banco
        /// </summary>
        /// <returns></returns>
        DbConnection GetDbconnection();
        
        T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        
        List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        
        int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        /// <summary>
        /// Executa uma instrução insert no banco de dados
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
        
        /// <summary>
        /// Executa uma instrução update no banco e dados
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure);
    }   
}

