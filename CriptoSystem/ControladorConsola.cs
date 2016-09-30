using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class ControladorConsola:CryptoSystem
    {
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
            return listaDatos.getDatos();
        }

        protected override bool guardarResultado(int pTipoArchivo) {
            throw new NotImplementedException();
        }

        

        
    }
}
