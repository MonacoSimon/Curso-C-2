using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Perro p1 = new Perro("dalmata");
            p1.Nombre = "tobi";
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
