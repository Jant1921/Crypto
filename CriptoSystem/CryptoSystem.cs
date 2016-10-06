using System;
using System.Collections.Generic;
using System.Linq;

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
            crearAlfabeto();
            fabrica = new Fabrica();
            listaDatos.Alfabeto = alfabeto;
            Traductor.Dto = listaDatos;
            Persistencia.Dto = listaDatos;
            traductores = fabrica.getTraductores().ToArray();
            persistencia = fabrica.getAlgoritmosPersistencia().ToArray();
        }

        public void crearAlfabeto() {
            alfabeto = SingletonAlfabeto.getInstance();
        }
        

        public bool verificarString(string pTexto) {
            char[] exceptions = { ' ', '1', '0', '*' };
            for(int i = 0; i < pTexto.Length; i++) {
                if( exceptions.Contains(pTexto.ElementAt(i))) {
                    continue;
                }
                if(!alfabeto.Caracteres.Contains("" + pTexto.ElementAt(i))) {
                    return false;
                }
            }
            return true;
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
