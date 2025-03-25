using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PD651.Models
{
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la materia es obligatorio")]
        [StringLength(100)]
        [Column("materia")]
        public string MateriaNombre { get; set; }

        [Required(ErrorMessage = "Las unidades valorativas son obligatorias")]
        [Range(1, 20, ErrorMessage = "Debe estar entre 1 y 20")]
        [Column("unidades_valorativas")]
        public int UnidadesValorativas { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "El estado solo puede ser 0 (inactivo) o 1 (activo)")]
        [Column("estado")]
        public char Estado { get; set; }
    }
}
