using System.ComponentModel.DataAnnotations;

namespace backend_integrador.Models
{
    public class Empresa
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        [Required]
        public int Ruc { get; set; } 
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Picture { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
