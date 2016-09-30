using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    abstract class Traductor
    {
        static Datos dto;
        string alfabeto;
        
        public abstract void codificar();
        public abstract void decodificar();

        public static Datos Dto {
            get { return dto; }
            set { dto = value; }
        }

        public string Alfabeto {
            get { return alfabeto; }
            set { alfabeto = value; }
        }


    }
}
