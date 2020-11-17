namespace desafio_back.Models
{
    /// <summary>
    /// Anuncio
    /// </summary>
    public class AnuncioResponse
    {
        /// <summary>
        /// Código de identificação do anúncio
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Marca do veículo
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// Versão do veículo
        /// </summary>
        public string Versao { get; set; }
        
        /// <summary>
        /// Modelo do veículo
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Ano do veículo
        /// </summary>
        public int Ano { get; set; }
        
        /// <summary>
        /// Quilometragem "rodada" do veículo
        /// </summary>
        public int Quilometragem { get; set; }
        
        /// <summary>
        /// Observação do anúncio do veículo
        /// </summary>
        public string Observacao { get; set; }
    }
}