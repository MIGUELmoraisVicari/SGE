using Microsoft.EntityFrameworkCore;

namespace SGE.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Professores> Professores { get; set; }
        public DbSet<Professores> Alunos { get; set; }
        public DbSet<Professores> Materias { get; set; }
        public DbSet<Professores> Etapas { get; set; }
        public DbSet<Professores> Notas { get; set; }

    }
}
