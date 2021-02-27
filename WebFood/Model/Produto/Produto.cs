using System;
using System.Collections.Generic;

namespace WebFood.Model
{
    /// <summary>
    /// Descreve um produto genérico da loja
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Id de identificação do produto
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Código personalizável de referência ao produto
        /// </summary>
        public string CodigoReferencia { get; set; }
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// quantidade da embalagem do produto
        /// </summary>
        public decimal QtdeEmbalagem { get; set; }
        /// <summary>
        /// Codigo Ncm do produto
        /// </summary>
        public string Ncm { get; set; }
        
        
        /// <summary>
        /// unidade de medida do produto
        /// </summary>
        public UnidadeDeMedida UnidadeMedida { get; set; }

        public List<AliquotasProdutos> Aliquotas { get; set; }
        /// <summary>
        /// Tipo do produto
        /// </summary>
        public TipoProduto TipoProduto { get; set; }
        /// <summary>
        /// Status atual do produto (Ativo/Inativo)
        /// </summary>
        public bool Status { get; set; }
    }
}
