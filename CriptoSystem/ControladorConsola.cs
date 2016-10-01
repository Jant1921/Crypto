using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class ControladorConsola:CryptoSystem
    {

        public int numeroPersistencia;

        public override void codificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).codificar();
            guardarResultado(numeroPersistencia);
        }

        public override void decodificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).decodificar();
            persistencia.ElementAt(numeroPersistencia).guardarArchivo();
            guardarResultado(numeroPersistencia);
        }

        public override string retornarResultado() {
            return listaDatos.getDatos();
        }

        protected override bool guardarResultado(int pTipoArchivo) {
            return persistencia.ElementAt(pTipoArchivo).guardarArchivo();
        }

        

        
    }
}
