using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public string Titulo { get; set; }
        public int IdEstilo { get; set; }
        public int CantidadCanciones { get; set; }
        public string FechaLanzamiento { get; set; }
        public string UrlImagenTapa { get; set; }
        public TipoEdicion Descipcion { get; set; }
    }
}
