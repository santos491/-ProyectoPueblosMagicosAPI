using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess
{
    public class Restaurantes : EntityBasic
    {
        
        [Required]
        [StringLength(200)]
        public string Nombre_Restaurante { get; set; }

        [Required]
        public int Telefono_Restaurante { get; set; }

        [Required]
        [StringLength(700)]
        public string Descripcion_Menu { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion_Restaurante { get; set; }

        [Required]
        [StringLength(200)]
        public string Municipio_Restaurante { get; set; }

    }
}
