using Microsoft.EntityFrameworkCore;

namespace L01P022022PD651.Models
{
    public class NotasContext:DbContext
    {
        public NotasContext(DbContextOptions<NotasContext> options) : base(options)
        {
        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Materia> Materias { get; set; }

    }
}
