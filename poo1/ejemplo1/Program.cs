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

            Persona p1 = new Persona();
            p1.setEdad(5);
            Botella b1 = new Botella();

            b1.Capacidad = 200;

            int algo = b1.Capacidad;

            Console.WriteLine("la edad de la persona es " + p1.getEdad());
            Console.ReadKey();

        }
    }
}
