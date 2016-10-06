using System;
using System.Collections.Generic;
using System.Linq;

namespace CriptoSystem
{
    class ControladorConsola:CryptoSystem
    {
        List<int> formatosSalida=new List<int>();

        public override void codificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).codificar();
            escribirEnArchivos();
        }

        public override void decodificar(string pTexto, int pTipoAlgoritmo) {
            listaDatos.FraseOriginal = pTexto;
            listaDatos.Fecha = DateTime.Now.ToString();
            traductores.ElementAt(pTipoAlgoritmo).decodificar();
            escribirEnArchivos();
        }

        public override string retornarResultado() {
            return listaDatos.getDatos();
        }

        protected override bool guardarResultado(int pTipoArchivo) {
            return persistencia.ElementAt(pTipoArchivo).guardarArchivo();
        }

        protected bool escribirEnArchivos() {
            bool finalizadoConExito = true;
            foreach(int tipo in formatosSalida) {
                finalizadoConExito = guardarResultado(tipo);
            }
            return finalizadoConExito;
        }

        public void agregarTipoArchivo(int pTipo) {
            if(!formatosSalida.Contains(pTipo)) {
                formatosSalida.Add(pTipo);
            }
        }

        public void limpiarArchivosSeleccionados() {
            formatosSalida.Clear();
        }
        

        
    }
}
