using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    abstract class Traductor
    {
        public abstract string codificar(string pTexto, string pValor);
        public abstract string decodificar(string pTexto, string pValor);
        public abstract string tipoValor();
    }
}
