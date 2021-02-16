using System;

namespace WebFood.Model.Cliente
{
    /// <summary>
    /// Descreve um telefone
    /// </summary>
    public class Telefone
    {
        /// <summary>
        /// Id de identificação uníco
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Codigo de area DDD do telefone
        /// </summary>
        public string DDD { get; set; }
        /// <summary>
        /// Numero do telefone
        /// </summary>
        public string Numero { get; set; }
        /// <summary>
        /// Status do telefone
        /// </summary>
        public bool Status { get; set; }
    }
}