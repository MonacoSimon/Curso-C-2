using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraMetodos
{
    class Canario : AnimalDomestico, IComparable, flyable
    {
        public string volar()
        {
            return "vuela como un canario...";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
