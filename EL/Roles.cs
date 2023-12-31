﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Roles")]
    public class Roles
    {
        [Key]

        public short IdRol { get; set; }
        [Required][MaxLength(50)]
        public string Rol { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get;set; }

        [Required]
        public int? IdUsuarioActualiza { get; set; }

        [Required]
        public DateTime? FechaActualizacion { get; set; }

        public Roles() 
        {
            Rol = string.Empty;
            
       
        }

    }
}
