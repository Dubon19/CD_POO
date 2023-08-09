using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClifforDubon_proyecto_de_consola
{
    public class Cliente
    {
        public int ID { get; set; }

        public string Nombre { get; set; } 
        
        public string Correo { get; set;}

        public string CeluLar { get; set; }
           
        public  Cliente () 
        { 
            ID = 0;
            Nombre= string.Empty;
            Correo = string.Empty;
            CeluLar = string.Empty;
        
        }  
        
        public void GetSaludo()
        {
            Console.WriteLine("Hola estimado" + Nombre);

        }
     }
}
