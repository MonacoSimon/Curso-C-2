using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //Persona: edad, nombre, sueldo
        private int edad;
        private float sualdo;
        private string nombre;

        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        //metodo

        public string saludar()
        {
            return "hola soy " + nombre;
        }

        public string saludar(string personaje)
        {
            return "hola " + nombre + "soy " + nombre;
        }

    }
}
