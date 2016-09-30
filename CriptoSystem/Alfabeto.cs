using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class Alfabeto{
        private string caracteres;
        private string nombre;
        public Alfabeto(string pCaracteres = "abcdefghijklmnopqrstuvwxyz", string pNombre = "abcedario")
        {
            Caracteres = pCaracteres;
            Nombre = pNombre;
        }

        public string Caracteres{
            get { return caracteres; }
            set { caracteres = value; }
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
