using System;
using System.ComponentModel.DataAnnotations;

namespace Entitiess
{
    public class ArtesanoData : EntityBasic
    {

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(200)]
        public string Apellido_Paterno { get; set; }
        [Required]
        [StringLength(200)]
        public string Apellido_Materno { get; set; }
        [Required]
        [StringLength(200)]
        public DateTime Fecha_Registro { get; set; }
        [Required]
        [StringLength(200)]
        public string Municipio { get; set; }
        [Required]
        [StringLength(500)]
        public string Email { get; set; }
        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        [Required]
        [StringLength(200)]
        public string Nombre_Negocio { get; set; }
    }
}
