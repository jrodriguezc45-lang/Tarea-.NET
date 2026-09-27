using System.ComponentModel.DataAnnotations;

namespace ClienteApi.Models
{
    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set; }

        [Required]
        [StringLength(13)]
        public string CUI { get; set; } = string.Empty;

        [Required]
        [StringLength(9)]
        public string NIT { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Direccion { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [Required]
        public DateTime Fecha_Nacimiento { get; set; }
    }
}
