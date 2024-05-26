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
            int a;
            
            Telefono t1 = new Telefono("nike phantom", "nike");
            Console.WriteLine("escriba un codigo de operador: ");
            a = int.Parse(Console.ReadLine());
            t1.CodigoOperador = 2;
            t1.CodigoOperador = a;
            Console.WriteLine(t1.CodigoOperador);
            //if(t1.CodigoOperador == 1)
            //{
            //    Console.WriteLine("su codigo de operador es: " + t1.CodigoOperador);
            //}
            //else if(t1.CodigoOperador == 2)
            //{
            //    Console.WriteLine("su codigo de operador es: " + t1.CodigoOperador);
            //}
            //else if (t1.CodigoOperador == 3)
            //{
            //    Console.WriteLine("su codigo de operador es: " + t1.CodigoOperador);
            //}
            //else
            //{
            //    Console.WriteLine("codigo de operador incorrecto");
            //}
            Console.ReadKey();
        }
    }
}
