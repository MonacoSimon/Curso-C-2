using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (codigoOperador == 1)
                {
                    codigoOperador = value;
                }
                else if (codigoOperador == 2)
                {
                    codigoOperador = value;
                }
                else if (codigoOperador == 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }


    }
}
