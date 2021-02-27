using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFood.Model
{
    /// <summary>
    /// Entidade que representa o Grupo do produto
    /// </summary>
    public class Grupo:EnumBaseType
    {
        /// <summary>
        /// propriedade que represanta a categoria do Grupo
        /// </summary>
        public Categoria Categoria { get; set; }
    }
}
