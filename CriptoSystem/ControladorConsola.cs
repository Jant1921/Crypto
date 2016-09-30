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
            persistencia.ElementAt(1).guardarArchivo();          
            persistencia.ElementAt(0).guardarArchivo();

        }

        public override void decodificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).decodificar();
            persistencia.ElementAt(1).guardarArchivo();
           
            persistencia.ElementAt(0).guardarArchivo();
        }

        public override string retornarResultado() {
            return listaDatos.getDatos();
        }

        protected override bool guardarResultado(int pTipoArchivo) {
            throw new NotImplementedException();
        }

        

        
    }
}
