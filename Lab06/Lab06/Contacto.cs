using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Clave => Apellido?.Substring(0, 1);
    }
}
