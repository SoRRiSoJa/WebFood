namespace WebFood.DTO.Cliente
{
    public class TelefoneDTO
    {
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