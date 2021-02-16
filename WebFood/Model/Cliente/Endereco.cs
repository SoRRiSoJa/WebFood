using System;
using System.Spatial;

namespace WebFood.Model.Cliente
{
    /// <summary>
    /// Representa um endereço
    /// </summary>
    public class Endereco
    {
        /// <summary>
        /// Id do Endereço
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Codigo de endereçamento postal do endereço
        /// </summary>
        public string Cep { get; set; }
        /// <summary>
        /// Logradouro do endereço
        /// </summary>
        public string Logradouro { get; set; }
        /// <summary>
        /// Complemento d logradouro
        /// </summary>
        public string Complemento { get; set; }
        /// <summary>
        /// Bairro do endereço
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Cidade do endereço
        /// </summary>
        public string Localidade { get; set; }
        /// <summary>
        /// Uf da cidade da localidade do endereço
        /// </summary>
        public string Uf { get; set; }
        /// <summary>
        /// Código Ibge
        /// </summary>
        public string Ibge { get; set; }
        /// <summary>
        /// codigo gia
        /// </summary>
        public string Gia { get; set; }
        /// <summary>
        /// DDD da Localidade
        /// </summary>
        public string Ddd { get; set; }
        /// <summary>
        /// Código siafi da localidade
        /// </summary>
        public string Siafi { get; set; }
        /// <summary>
        /// Coordenada Geografica do endereço.
        /// </summary>
        public GeographyPoint LocalizacaoGeografica { get; set; }
        /// <summary>
        /// Tipo do Endereco
        /// </summary>
        public TipoEndereco TipoEndereco { get; set; }
    }
}