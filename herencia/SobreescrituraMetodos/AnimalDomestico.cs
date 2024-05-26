using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraMetodos
{
    class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return "animal: " + Nombre;
        }

        //public string MostarNombre()
        //{
        //    return Nombre;
        //}
    }
}
