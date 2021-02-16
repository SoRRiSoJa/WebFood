namespace WebFood.Model
{
    /// <summary>
    /// Descreve a categoria do produto
    /// </summary>
    public class Categoria:EnumBaseType
    {
        /// <summary>
        /// Grupo de produto a qual a categoria pertence
        /// </summary>
        public Grupo Grupo { get; set; }
    }
}