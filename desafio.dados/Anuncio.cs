using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace desafio.dados
{
    public class Anuncio
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Column("marca")]
        [MaxLength(45)]
        [Required]
        public string Marca { get; set; }

        [Column("modelo")]
        [MaxLength(45)]
        [Required]
        public string Modelo { get; set; }

        [Column("versao")]
        [MaxLength(45)]
        [Required]
        public string Versao { get; set; }

        [Column("ano")]
        [Required]
        public int Ano { get; set; }

        [Column("quilometragem")]
        [Required]
        public int Quilometragem { get; set; }

        [Column("observacao")]
        [Required]
        public string Observacao { get; set; }
    }
}
