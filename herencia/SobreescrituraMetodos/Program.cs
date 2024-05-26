using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            AnimalDomestico a1 = new AnimalDomestico();
            Gato g1 = new Gato();
            Perro p1 = new Perro();
            g1.Nombre = "pepe";
            a1.Nombre = "pepe";


            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Canario());
            animales.Add(new Aguila());

            List<flyable> listaVoladores = new List<flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.Comunicarse());

            //}
            //Animal an1 = g1;
            //Gato g8 = an1;
            //Gato g8 = (Gato)an1;


            Console.WriteLine(g1.Comunicarse());
            Console.WriteLine(p1.Comunicarse());
            Console.ReadKey();


        }
    }
}
