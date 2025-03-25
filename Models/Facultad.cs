using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace L01P022022PD651.Models
{
    public class Facultad
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la facultad es obligatorio")]
        [StringLength(100)]
        [Column("facultad")]
        public string FacultadNombre { get; set; }
    }
}
