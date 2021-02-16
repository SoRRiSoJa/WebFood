using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFood.Model
{
    public enum ETipoProduto
    {
        /// <summary>
        /// Combo de produtos, combinado de dois ou mais produtos em um unico preço
        /// </summary>
        COMBO,
        /// <summary>
        /// Produto final composto de seus pre-preparos e produtos
        /// </summary>
        FICHA_TECNICA,
        /// <summary>
        /// Insumo utilizado nas preparações 
        /// </summary>
        INSUMO,
        /// <summary>
        /// Mercadoria para venda
        /// </summary>
        MERCADORIA,
        /// <summary>
        /// Pré preparação como strogonof, arroz, feijão, batata frita
        /// </summary>
        PRE_PREPARO
    }
}
