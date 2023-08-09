﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("RolPermiso")]

    public class RolPermiso
    {
        [key]
        public int IdRolPermiso { get; set; }

        [Required]
        public short IdRol { get; set; }

        [Required]
        public int IdPermiso { get; set; }

        [Required]
        public int IdFormularios { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }


        public int? IdUsuarioActualiza { get; set; }


        public DateTime? FechaActualizacion { get; set; }

    }
}
