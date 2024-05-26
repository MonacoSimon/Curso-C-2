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
            DateTime fecha = DateTime.Now;

            

            Console.WriteLine("la fecha es: " + fecha.ToString("f"));

            Console.ReadKey();
        }
    }
}
