using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class SingletonAlfabeto
    {
        private static Alfabeto alfabeto;
        private SingletonAlfabeto()
        {
            
        }

        private static Alfabeto crearAlfabeto()
        {
            return new Alfabeto("abcdefghijklmnopqrstuvwxyz","abcdario");
        }

        public static Alfabeto getInstance()
        {
            if(alfabeto == null)
            {
                alfabeto=crearAlfabeto();
            }
            return alfabeto;
        }

        public static Alfabeto getInstance(string pCaracteres, string pNombre)
        {
            if (alfabeto == null)
            {
                alfabeto = new Alfabeto(pCaracteres, pNombre);
            }
            return alfabeto;
        }
    }
}
