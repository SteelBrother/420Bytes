using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420BytesProyect.DT.Usuario
{
    public class Usuario
    {
        public int Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }  
        public string? Password { get; set; } 
        public string Ciudad {  get; set; }
        public string Pais { get; set; }
        public int Edad { get; set; }
        public string? NickName { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }

}
