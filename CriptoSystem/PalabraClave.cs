using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoSystem
{
    class PalabraClave : Traductor
    {
        public override void codificar(){
            Alfabeto = Dto.Alfabeto.Caracteres;
            string pTexto = Dto.FraseOriginal;
            string pValor = Dto.ValorCodificacion;
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
            Alfabeto = Dto.Alfabeto.Caracteres;
            string pTexto = Dto.FraseOriginal;
            string pValor = Dto.ValorCodificacion;
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
    }
}
