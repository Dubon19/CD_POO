using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Permisos")]
    
    public class permisos

    {
        [Key]

        
        public int IdPermisos { get; set; }

        [Required]
        public string Permiso { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [Required]
        public int? IdUsuarioActualiza { get; set; }

        [Required]
        public DateTime? FechaActualizacion { get; set; }

        public permisos()
        {
            Permiso= string.Empty;

        }
    }
}
