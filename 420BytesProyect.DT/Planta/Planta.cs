﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420BytesProyect.DT.Planta
{
    public class Planta
    {
        public int IdPlanta { get; set; }
        public int IdDispositivo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int IdControlPH { get; set; }
        public int IdControlEC { get; set; }
        public int IdControlHA { get; set; }
        public int IdControlHS { get; set; }
        public int IdControlIN { get; set; }
        public int IdControlPPFD { get; set; }
        public int IdControlTA { get; set; }
        public int IdControlTS { get; set; }

    }

}
