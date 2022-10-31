﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLaboratorio.Models
{
    public class PrestamosEmpleados
    {
        public int numero_de_control { get; set; }
        public string nombre { get; set; }
        public string celular { get; set; }
        public string necesidad { get; set; }
        public string herramienta { get; set; }
        public string cantidad { get; set; }
        public string fecha_salida { get; set; }
        public string fecha_regreso { get; set; }
    }

}
