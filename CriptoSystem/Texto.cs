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
       
    
        public override bool guardarArchivo()
        {
            String nombreArchivo = "swagtexto.txt";
            String[] pTexto = { Dto.getDatos() };
            if (!File.Exists(nombreArchivo))
            {
                System.IO.File.WriteAllLines(nombreArchivo, pTexto);
                return true;
               

            }
            else {
                System.IO.File.AppendAllLines(nombreArchivo, pTexto);

            }
            return false;
        }
    }
}
