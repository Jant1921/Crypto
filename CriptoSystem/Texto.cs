using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CriptoSystem
{
    class Texto : Persistencia
    {
        public override bool guardarArchivo(string nombreArchivo, string[] pTexto)
        {
            if (!File.Exists(nombreArchivo))
            {
                System.IO.File.WriteAllLines(nombreArchivo, pTexto);
                return true;
            }
            return false;
        }
    }
}
