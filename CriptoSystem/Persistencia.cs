using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    abstract class Persistencia
    {
        public abstract bool guardarArchivo(string nombreArchivo, string[] pTexto);
        protected String componerString(String[] arrayString)
        {
            String temp = "";
            for (int i = 0; i < arrayString.Length; i++)
            {
                temp = temp + arrayString[i] + "\n";
            }
            return temp;
        }

    }
}
