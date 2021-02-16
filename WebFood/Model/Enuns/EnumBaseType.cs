using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFood.Model
{
    /// <summary>
    /// Representa o tipo basico de herança para as tabelas de enum;
    /// </summary>
    public class EnumBaseType
    {
        /// <summary>
        /// id identificador do enum
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Descrição
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Status do item
        /// </summary>
        public bool Status { get; set; }
    }
}
