using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class Transposicion : Traductor
    {
        public override string codificar(string pTexto)
        {
            string[] temp = pTexto.Split(' ');
            string res = "";
            for(int i = 0; i < temp.Length; i++)
            {
                for(int j = temp[i].Length - 1; j >= 0; j--)
                {
                    res = res + temp[i].ElementAt(j);
                }
                res = res + " ";
            }
            return res;
        }

        public override string decodificar(string pTexto)
        {
            return codificar(pTexto);
        }
    }
}
