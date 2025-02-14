using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nota")]
        [Display(Name = "Nota")]
        public double Nota { get; set; }

        [ForeignKey("Materias_FK")]
        [Display(Name = "Materias")]
        public int MateriasId { get; set; }
        public Materias? Materias { get; set; }

        [ForeignKey("Alunos_FK")]
        [Display(Name = "Alunos")]
        public int AlunosId { get; set; }
        public Alunos? Alunos { get; set; }

        [ForeignKey("Etapas_FK")]
        [Display(Name = "Etapas")]
        public int EtapasId { get; set; }
        public Etapas? Etapas { get; set; }

    }
}
