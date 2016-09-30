using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class Transposicion : Traductor
    {
        public override void codificar(){
            cargarDatos();
            Dto.TipoTraduccion = "Codificacion";
            string[] temp = pTexto.Split(' ');
            string res = "";
            for(int i = 0; i < temp.Length; i++)
            {
                for(int j = temp[i].Length - 1; j >= 0; j--)
                {
                    res = res + temp[i].ElementAt(j);
                }
                res = res + " ";
            }
            Dto.FraseResultado = res;
        }

        public override void decodificar()
        {
            codificar();
            Dto.TipoTraduccion = "Decodificacion";
        }


        protected override void cargarDatos() {
            Alfabeto = Dto.Alfabeto.Caracteres;
            pTexto = Dto.FraseOriginal;
            Dto.NombreAlgoritmo = "Transposicion";
        }

    }
}
