using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PD651.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio")]
        [StringLength(10)]
        [Column("codigo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50)]
        [Column("nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        [StringLength(50)]
        [Column("apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El DUI es obligatorio")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El DUI debe tener exactamente 9 dígitos")]
        [Column("dui")]
        public int Dui { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "El estado solo puede ser 0 (inactivo) o 1 (activo)")]
        [Column("estado")]
        public int Estado { get; set; }
    }
}
