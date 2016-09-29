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
        private bool codifica;
        public string nombreAlgoritmo;
        public string valorCodificacion;
        public Alfabeto alfabeto;

        public string Fecha {
            get { return fecha; }
            set { fecha = DateTime.Now.ToString(); }
        }

        public string FraseOriginal {
            get { return fraseOriginal; }
            set { FraseOriginal = value; }
        }

        public string FraseResultado{
            get { return fraseResultado; }
            set { fraseResultado= value; }
        }

        public bool Codifica{
            get { return codifica; }
            set { codifica = value; }
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
