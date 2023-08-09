using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Formularios")]
    

        
        public class Formularios
        {
            [Key]

            
            public int IdFormularios { get; set; }
            
            [Required]
            
            public string Formulario { get; set; }

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

        public Formularios()
        {
            Formulario= string.Empty;
        }

    }
}
