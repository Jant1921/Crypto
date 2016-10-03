using System.Linq;
namespace CriptoSystem
{
    class PalabraClave : Traductor
    {
        private string pValor;

        public override void codificar(){
            cargarDatos();
            Dto.TipoTraduccion = "Codificacion";
            string res = "";
            string[] arregloPalabras = pTexto.Split(' ');
            for (int i = 0; i < arregloPalabras.Length; i++)
            {
                for (int j = 0; j < arregloPalabras[i].Length; j++)
                {
                    res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) + 1 + (Alfabeto.IndexOf(pValor.ElementAt(j % pValor.Length)))) % Alfabeto.Length);
                }
                res = res + " ";
            }

            Dto.FraseResultado = res;
        }

        public override void decodificar(){
            cargarDatos();
            Dto.TipoTraduccion = "Decodificacion";
            string res = "";
            string[] arregloPalabras = pTexto.Split(' ');
            for (int i = 0; i < arregloPalabras.Length; i++)
            {
                for (int j = 0; j < arregloPalabras[i].Length; j++)
                {
                    if (0 > (Alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) - 1 - (Alfabeto.IndexOf(pValor.ElementAt(j % pValor.Length)))) % Alfabeto.Length)
                    {
                        res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) - 1 - (Alfabeto.IndexOf(pValor.ElementAt(j % pValor.Length))) + Alfabeto.Length));
                    }
                    else
                    {
                        res = res + Alfabeto.ElementAt((Alfabeto.IndexOf(arregloPalabras[i].ElementAt(j)) - 1 - (Alfabeto.IndexOf(pValor.ElementAt(j % pValor.Length)))));
                    }

                }
                res = res + " ";
            }

            Dto.FraseResultado = res;
        }

        protected override void cargarDatos() {
            Alfabeto = Dto.Alfabeto.Caracteres;
            pTexto = Dto.FraseOriginal;
            pValor = "tango";
            Dto.NombreAlgoritmo = "Palabra Clave";
        }
    }
}
