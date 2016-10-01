using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;

namespace CriptoSystem
{
    abstract class CryptoSystem
    {

        protected Traductor[] traductores;
        protected Persistencia[] persistencia;
        protected Datos listaDatos;
        protected Fabrica fabrica;
        protected Alfabeto alfabeto;



        public CryptoSystem() {
            listaDatos = new Datos();
            alfabeto = SingletonAlfabeto.getInstance();
            fabrica = new Fabrica();
            listaDatos.Alfabeto = alfabeto;
            Traductor.Dto = listaDatos;
            Persistencia.Dto = listaDatos;
            traductores = fabrica.getTraductores().ToArray();
            persistencia = fabrica.getAlgoritmosPersistencia().ToArray();
        }


        protected abstract bool guardarResultado(int pTipoArchivo);
        public abstract void codificar(string pTexto,int pTipoAlgoritmo);
        public abstract void decodificar(string pTexto, int pTipoAlgoritmo);
        public abstract string retornarResultado();

        public string getNombreAlgoritmo(Object algoritmo) {
            return algoritmo.GetType().ToString().Split('.').ElementAt(1);
        }

        public string[] getNombresTraductores() {
            return getNombreAlgoritmosEnArray(traductores);
        }

        public string[] getNombresPersistencia() {
            return getNombreAlgoritmosEnArray(persistencia);
        }

        public string[] getNombreAlgoritmosEnArray(Object[] elem) {
            List<string> nombres = new List<string>();
            for(int indice = 0; indice < elem.Length; indice++) {
                nombres.Add(getNombreAlgoritmo(elem.ElementAt(indice)));
            }
            return nombres.ToArray();
        }

       

    }
}
