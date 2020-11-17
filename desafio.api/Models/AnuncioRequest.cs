using System.ComponentModel.DataAnnotations;

namespace desafio_back.Models
{
    /// <summary>
    /// Anúncio
    /// </summary>
    public class AnuncioRequest
    {
        /// <summary>
        /// Marca do veículo
        /// </summary>
        [Required(ErrorMessage = "Obrigatório o preenchimento da marca")]
        [MaxLength(45, ErrorMessage ="A marca do veículo pode ter apenas 45 caracteres")]
        public string Marca { get; set; }
        /// <summary>
        /// Versão do veículo
        /// </summary>
        [Required(ErrorMessage = "Obrigatório o preenchimento da versão")]
        [MaxLength(45, ErrorMessage = "A marca do veículo pode ter apenas 45 caracteres")]
        public string Versao { get; set; }
        /// <summary>
        /// Modelo do veículo
        /// </summary>
        [Required(ErrorMessage = "Obrigatório o preenchimento do modelo")]
        [MaxLength(45, ErrorMessage = "A marca do veículo pode ter apenas 45 caracteres")]
        public string Modelo { get; set; }
        /// <summary>
        /// Ano do veículo
        /// </summary>
        [Required(ErrorMessage ="Obrigatório o preenchimento do ano do veículo")]
        public int Ano { get; set; }
        /// <summary>
        /// Quilometragem "rodada" do veículo
        /// </summary>
        [Required(ErrorMessage = "Obrigatório o preenchimento da quilometragem")]
        public int Quilometragem { get; set; }
        /// <summary>
        /// Observação do anúncio do veículo
        /// </summary>
        [Required(ErrorMessage = "Obrigatório o preenchimento de alguma observação no anúncio")]
        public string Observacao { get; set; }
    }
}