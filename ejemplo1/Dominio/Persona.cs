using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public string EstadoCivil { get; set; }
        public Domicilio calle { get; set; }
        public Domicilio localidad { get; set; }
        public Domicilio provincia { get; set; }
    }
}
