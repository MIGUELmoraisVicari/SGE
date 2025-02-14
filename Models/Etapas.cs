using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {

        [Column("Id")]
        [Display(Name = "Id Etapa")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Titulo da Etapa")]
        public string Titulo { get; set; } = string.Empty;

        [Column("Ano")]
        [Display(Name = "Ano da Etapa")]
        public string Ano { get; set; } = string.Empty;

    }
}
