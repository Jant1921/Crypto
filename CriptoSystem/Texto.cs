using System;
using System.IO;

namespace CriptoSystem
{
    class Texto : Persistencia
    {
       
    
        public override bool guardarArchivo()
        {
            String nombreArchivo = "ArchivoTexto.txt";
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
