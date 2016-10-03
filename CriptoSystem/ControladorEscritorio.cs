using System;
using System.Linq;

namespace CriptoSystem
{
    class ControladorEscritorio : CryptoSystem {
        public int numeroPersistencia;

        public override void codificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).codificar();
        }

        public override void decodificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).decodificar();
        }

        public override string retornarResultado() {
            return listaDatos.FraseResultado;
        }


        protected override bool guardarResultado(int pTipoArchivo) {
            return persistencia.ElementAt(pTipoArchivo).guardarArchivo();
        }

        public void guardar() {
            guardarResultado(numeroPersistencia);
        }

    }
}
