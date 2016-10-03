using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    abstract class Persistencia
    {
        static Datos dto;
        public string nombreArchivo;
        public static Datos Dto
        {
            get { return dto; }
            set { dto = value; }
        }

        public abstract bool guardarArchivo();
    }
}
