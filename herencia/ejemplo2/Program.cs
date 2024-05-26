using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Camioneta c1 = new Camioneta();
            //    Camioneta c3 = new Camioneta();
            //    Camioneta c2 = new Camioneta();
            //    c1.Color = "amarillo";
            //    c2.Color = "blanco";
            //    c3.Color = "rojo";
            //    List<Camioneta> listaCamionetas = new List<Camioneta>();
            //    listaCamionetas.Add(c1);
            //    listaCamionetas.Add(c2);
            //    listaCamionetas.Add(c3);

            //    //Console.WriteLine("la cantidad de comionetas es: " + listaCamionetas.Count);
            //    //Console.WriteLine("el color es: " + listaCamionetas[1].Color);
            //    //listaCamionetas.Remove(c3);

            //    foreach (Camioneta camioneta in listaCamionetas)
            //    {
            //        Console.WriteLine("color: " + camioneta.Color);


            //    }

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();
        }
    }
}
