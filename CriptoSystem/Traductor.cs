using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    abstract class Traductor
    {
        Datos dto;
        Traductor (Datos pDto) {
            this.dto = pDto;
        }
        public abstract void codificar();
        public abstract void decodificar();
        
    }
}
