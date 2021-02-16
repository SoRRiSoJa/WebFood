using System;

namespace WebFood.DTO.Cliente
{
    public class EnderecoDTO
    {
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
    }
}