using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EL
{
    [Table("Usuarios")]
    public class Usuarios
    {
        
        
      
            [Key]

       
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(200)]
        public string NombreCompleto { get; set; }

        [Required]
        [MaxLength(200)]
        public string Correo { get; set; }

       
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        public byte[] Password { get; set; }

        [Required]
        public bool Bloqueado { get; set; }

        [Required]
        public byte IntentosFallidos { get; set; }

        [Required]
        public short IdRol { get; set; }


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

            public Usuarios() 
            {
            Correo = string.Empty;
            UserName= string.Empty;
            NombreCompleto= string.Empty;
            Password = UTF8Encoding.UTF8.GetBytes(string.Empty);
        
        
            }

        }
}
