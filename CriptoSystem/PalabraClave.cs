using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class PalabraClave : Traductor
    {
        public string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        public override string codificar(string pTexto)
        {
            throw new NotImplementedException();
        }
        public string codi(string pTexto, string palabraClave)
        {
            string res = "";
            string[] arregloPalabras = pTexto.Split(' ');
            for(int i = 0; i < arregloPalabras.Length; i++)
            {
                for(int j = 0; j < arregloPalabras[i].Length; j++)
                {
                    res = res + alfabeto.ElementAt( (alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) +1+ (alfabeto.IndexOf(palabraClave.ElementAt(j%palabraClave.Length))))% alfabeto.Length);
                }
                res = res + " ";
            }

            return res;
        }
        public string decodi(string pTexto, string palabraClave)
        {
            string res = "";
            string[] arregloPalabras = pTexto.Split(' ');
            for (int i = 0; i < arregloPalabras.Length; i++)
            {
                for (int j = 0; j < arregloPalabras[i].Length; j++)
                {
                    if (0> (alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) - 1 - (alfabeto.IndexOf(palabraClave.ElementAt(j % palabraClave.Length)))) % alfabeto.Length)
                    {
                        res = res + alfabeto.ElementAt((alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) - 1 - (alfabeto.IndexOf(palabraClave.ElementAt(j % palabraClave.Length))) + alfabeto.Length));
                    }
                    else
                    {
                        res = res + alfabeto.ElementAt((alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) - 1 - (alfabeto.IndexOf(palabraClave.ElementAt(j % palabraClave.Length)))));
                    }
                    
                }
                res = res + " ";
            }

            return res;
        }


        public override string decodificar(string pTexto)
        {
            throw new NotImplementedException();
        }
    }
}
