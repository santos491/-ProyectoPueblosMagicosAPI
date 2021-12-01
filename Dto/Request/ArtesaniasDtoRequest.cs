using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Request
{
    public class ArtesaniasDtoRequest
    {
        [Required]
        [StringLength(200)]
        public string Nombre_Artesania { get; set; }
        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(100)]
        public string Materia_de_Elaboracion { get; set; }
        public bool Default { get; set; }
    }
}
