using System;
using System.Collections.Generic;

namespace WebFood.Model.Cliente
{
    /// <summary>
    /// Representa o CLiente
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Id de identificação do cliente
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Nime do cliente
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime DataNascmento { get; set; }
        /// <summary>
        /// Cpf do cliente
        /// </summary>
        public string Cpf { get; set; }
        /// <summary>
        /// Rg do cliente
        /// </summary>
        public string Rg { get; set; }
        /// <summary>
        /// Endereços
        /// </summary>
        public IEnumerable<Endereco> Endereco { get; set; }
        /// <summary>
        /// Telefones
        /// </summary>
        public IEnumerable<Telefone> Telefone { get; set; }
        public bool Status { get; set; }
    }
}
