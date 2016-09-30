using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class Datos
    {
        private string fecha;
        private string fraseOriginal;
        private string fraseResultado;
        private string tipoTraduccion;  //codificacion o decodificacion
        private string nombreAlgoritmo;
        private string valorCodificacion;
        private Alfabeto alfabeto;

        public string getDatos() {
            return "Fecha: " + Fecha + "\n" +
                   "Algoritmo: " + NombreAlgoritmo + "\n" +
                   "Tipo de Traduccion: " + TipoTraduccion + "\n" +
                   "Frase Original: " + FraseOriginal + "\n" +
                   "Resultado: " + FraseResultado + "\n";
        }

        public string Fecha {
            get { return fecha; }
            set { fecha = value; }
        }

        public string FraseOriginal {
            get { return fraseOriginal; }
            set { fraseOriginal = value; }
        }

        public string FraseResultado{
            get { return fraseResultado; }
            set { fraseResultado= value; }
        }

        public string TipoTraduccion{
            get { return tipoTraduccion; }
            set { tipoTraduccion = value; }
        }

        public string NombreAlgoritmo{
            get { return nombreAlgoritmo; }
            set { nombreAlgoritmo = value; }
        }

        public string ValorCodificacion {
            get { return valorCodificacion; }
            set { valorCodificacion = value; }
        }

        public Alfabeto Alfabeto {
            get { return alfabeto; }
            set { alfabeto = value; }
        }
    }
}
