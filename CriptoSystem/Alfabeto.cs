using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class Alfabeto
    {
        public string caracteres;
        public string nombre;
        public Alfabeto(string pCaracteres = "abcdefghijklmnopqrstuvwxyz", string pNombre = "abc")
        {
            caracteres = pCaracteres;
            nombre = pNombre;
        }
    }
}
