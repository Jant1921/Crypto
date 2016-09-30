using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class ControladorEscritorio : CryptoSystem {
        public override void codificar(string pTexto, int pTipoAlgoritmo) {
            throw new NotImplementedException();
        }

        public override void decodificar(string pTexto, int pTipoAlgoritmo) {
            throw new NotImplementedException();
        }

        public override string retornarResultado() {
            throw new NotImplementedException();
        }

        protected override bool guardarResultado(int pTipoArchivo) {
            throw new NotImplementedException();
        }

    }
}
