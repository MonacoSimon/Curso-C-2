using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Perro
    {
        public Perro(string raza)
        {
            this.raza = raza;
        }

        private int edad;
        private string nombre;
        private string raza;


        
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        //public string Raza
        //{
        //    get { return raza; }
        //    set { raza = value; }
        //}

        public string Saludar()
        {
            return "hola soy " + nombre;
        }
    }
}
