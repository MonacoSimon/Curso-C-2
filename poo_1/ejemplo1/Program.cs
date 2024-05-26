using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Persona: edad, nombre, sueldo
            //int edad;
            //float sualdo;
            //string nombre;

            Botella b1 = new Botella("rojo", "plastico");
            Persona p1 = new Persona("simon");
            p1.setEdad(20);
            //b1.Capacidad = 200;
            //Botella b2 = new Botella();
            //int algo = b1.Capacidad;
            Console.WriteLine("es" + p1.getEdad());
            //Console.WriteLine("la capacidad es: " + algo);
            Console.WriteLine(p1.saludar();
            Console.ReadKey();
        }
    }
}
