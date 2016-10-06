using System.Collections.Generic;

namespace CriptoSystem
{
    
    public class Dto
    {
        string abecedario;
        string tiraInicial;
        List<string> tiraFinal = new List<string>();
        string clave;
        string[] tipoAlgoritmo;
        string modo;
        string[] tipoArchivo;

        public string Modo
        {
            get
            {
                return modo;

            }
            set
            {
                modo = value;
            }
        }
        public string Abecedario
        {
            get
            {
                return abecedario;
            }

            set
            {
                abecedario = value;
            }
        }

        public string TiraInicial
        {
            get
            {
                return tiraInicial;
            }

            set
            {
                tiraInicial = value;
            }
        }

        public List<string> TiraFinal
        {
            get
            {
                return tiraFinal;
            }

            set
            {
                tiraFinal = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string[] TipoArchivo
        {
            get
            {
                return tipoArchivo;
            }

            set
            {
                tipoArchivo = value;
            }
        }

        public string[] TipoAlgoritmo
        {
            get
            {
                return tipoAlgoritmo;
            }

            set
            {
                tipoAlgoritmo = value;
            }
        }
    }
}