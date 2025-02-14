using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Alunos")]
    public class Alunos
    {

        [Column("Id")]
        [Display(Name = "Código do Aluno")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome do Aluno")]
        public string Nome { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "Cpf do Aluno")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email do Aluno")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Aluno")]
        public string Telefone { get; set; } = string.Empty;

        [Column("DtNascimento")]
        [Display(Name = "DtNascimento do Aluno")]
        public string DtNascimento { get; set; } = string.Empty;






    }
}
