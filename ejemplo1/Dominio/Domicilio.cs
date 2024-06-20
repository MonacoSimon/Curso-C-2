using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Domicilio
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public int Depto { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public override string ToString()
        {
            return $"{Calle}{Localidad}{Provincia}";
        }
        
    }
}
