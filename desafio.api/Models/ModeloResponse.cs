namespace desafio_back.Models
{
    /// <summary>
    /// Modelo
    /// </summary>
    public class ModeloResponse
    {
        /// <summary>
        /// Código do modelo
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Código identificador do fabricante do modelo de veículos
        /// </summary>
        public int FabricanteID { get; set; }        
        /// <summary>
        /// Nome do modelo do carro
        /// </summary>
        public string Nome { get; set; }
    }
}