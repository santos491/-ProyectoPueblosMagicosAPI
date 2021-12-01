using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Request
{
    public class ArtesanoDtoRequest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Apellido_Paterno { get; set; }

        [Required]
        [StringLength(200)]
        public string Apellido_Materno { get; set; }
       
        public DateTime Fecha_Registro { get; set; }

        [Required]
        [StringLength(200)]
        public string Municipio { get; set; }

        [EmailAddress]
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
