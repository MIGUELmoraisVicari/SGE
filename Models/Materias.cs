using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {

        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Titulo da Materia")]
        public string Titulo { get; set; } = string.Empty;

        [Column("ProfessoresId")]
        [Display(Name = "ProfessoresId da Materia")]
        public string ProfessoresId { get; set; } = string.Empty;
    }
}
